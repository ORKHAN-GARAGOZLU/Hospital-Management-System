using Lumina_Hospital.Entities.AppUser;
using Lumina_Hospital.ViewModel.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Lumina_Hospital.ViewModel.Admin.User;
using Lumina_Hospital.DAL;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly LuminaHospitalDbContex _context;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager, LuminaHospitalDbContex context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM account)
        {
            if (!ModelState.IsValid) return View();

            User user = new User
            {
                FullName = account.FullName,
                UserName = account.UserName,
                Email = account.Email,
            };

            IdentityResult result = await _userManager.CreateAsync(user, account.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(account);
            }

            await _userManager.AddToRoleAsync(user, "Admin");

			//Email verification

			var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

			var url = Url.Action(nameof(VerifyEmail), "Account", new { email = user.Email, token },
				Request.Scheme, Request.Host.ToString());

			MailMessage mailMessage = new();

			mailMessage.From = new MailAddress("orkhanqaragozov@gmail.com", "Verify Email");
			mailMessage.To.Add(new MailAddress(user.Email));
			mailMessage.Subject = "Verify your Email";

			string body = string.Empty;
			using (StreamReader streamReader = new StreamReader("wwwroot/templates/email/index.html"))
			{
				body = streamReader.ReadToEnd();
			}

			mailMessage.Body = body.Replace("{{link}}", url);
			mailMessage.IsBodyHtml = true;

			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Port = 587;
			smtpClient.Host = "smtp.gmail.com";
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential("orkhanqaragozov@gmail.com", "wrhi dcnt iiwo belq");
			smtpClient.Send(mailMessage);

			return RedirectToAction("login", "account");
		}

		public async Task<IActionResult> VerifyEmail(string email, string token)
		{
            User user = await _userManager.FindByEmailAsync(email);
            if (user == null) return NotFound();

            await _userManager.ConfirmEmailAsync(user, token);
            await _signInManager.SignInAsync(user, true);


            return RedirectToAction("Index", "Home");
		}

		public async Task<IActionResult> MyAccount() 
        {
            UserEditVM vm = new();
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                vm.FullName = user.FullName;
                vm.Email = user.Email;
                vm.UserName = user.UserName;
                vm.OrderInfo = _context.OrderInfos.Where(o => !o.IsDelete).Include(o => o.OrderDetails).FirstOrDefault();

            }
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> MyAccount(UserEditVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    user.FullName = model.FullName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;


                    if (!string.IsNullOrEmpty(model.NewPassword))
                    {
                        var isOldPasswordValid = await _userManager.CheckPasswordAsync(user, model.OldPassword);
                        if (!isOldPasswordValid)
                        {
                            ModelState.AddModelError("", "Old password is wrong");
                            return View(model);
                        }

                        var newPasswordHash = _userManager.PasswordHasher.HashPassword(user, model.NewPassword);
                        user.PasswordHash = newPasswordHash;
                    }

                    var result = await _userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        ViewBag.SuccessMessage = "Your account details have been updated successfully.";
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM, string? ReturnUrl)
        {
            if (!ModelState.IsValid) return View();

            User user = await _userManager.FindByEmailAsync(loginVM.UserNameOrEmail);

            //if (user == null || !await _userManager.IsEmailConfirmedAsync(user))
            //{
            //    ModelState.AddModelError("", "Verify your email");
            //    return View();

            //}
            if (user == null)
            {
                
                user = await _userManager.FindByNameAsync(loginVM.UserNameOrEmail);

                if (!user.EmailConfirmed)
                {
                    ModelState.AddModelError("", "Verify your account!, Check your email");
                    //await _signInManager.SignOutAsync();
                    return View();
                }
                if (user == null)
                {
                    ModelState.AddModelError("", "Username and Email or password is incorrect");
                    return View(loginVM);
                }

                var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.RememberMe, true);
                if (result.IsLockedOut)
                {
                    ModelState.AddModelError("", "Due to overtrying your account has been blocked for 5 minute!");
                    return View(loginVM);
                }

				if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Username and Email or password is incorrect");
                    return View(loginVM);
                }
			}

            

            await _signInManager.SignInAsync(user, loginVM.RememberMe);

            if (ReturnUrl != null)
            {
                return Redirect(ReturnUrl);
            }

            var roles = await _userManager.GetRolesAsync(user);

            foreach (var item in roles)
            {
                if (item == "Admin")
                {
                    return RedirectToAction("Index", "Dashboard", new { area = "LuminaHospitalArea" });
                }
            }



			return RedirectToAction("index", "home");
        }

        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM forgetVM)
        {
            User user = await _userManager.FindByEmailAsync(forgetVM.appUser.Email);
            if (user == null)
            {
                ModelState.AddModelError("Error", "This email is not found");
                return View();
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var link = Url.Action(nameof(ResetPassword), "Account", new {email = user.Email,
                token}, Request.Scheme,Request.Host.ToString());
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("orkhanqaragozov@gmail.com", "Lumina Hospital");
            mailMessage.To.Add(new MailAddress(user.Email));
            mailMessage.Subject = "Reset Password";
            mailMessage.Body = $"<a href={link}>Please Click Here</a>";
			mailMessage.IsBodyHtml = true;

			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Port = 587;
			smtpClient.Host = "smtp.gmail.com";
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential("orkhanqaragozov@gmail.com", "wrhi dcnt iiwo belq");

			smtpClient.Send(mailMessage);

			return Content("Please check email");
        }

		public IActionResult ResetPassword()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ResetPassword(string token, string email, ForgetPasswordVM forgetVM)
		{
			User user = await _userManager.FindByEmailAsync(email);
			if (user == null) return NotFound();

            
            //if (!ModelState.IsValid) return View();

            await _userManager.ResetPasswordAsync(user, token, forgetVM.Password);
            await _userManager.UpdateSecurityStampAsync(user);
            return RedirectToAction("login", "account");
		}

        public IActionResult FacebookLogin(string ReturnUrl)
        {
            string redirectUrl = Url.Action("FacebookResponse", "Account", new { ReturnUrl = ReturnUrl });
            AuthenticationProperties properties = _signInManager.ConfigureExternalAuthenticationProperties("Facebook", redirectUrl);
            return new ChallengeResult("Facebook", properties);
        }

        public async Task<IActionResult> FacebookResponse(string ReturnUrl = "/")
        {
            ExternalLoginInfo loginInfo = await _signInManager.GetExternalLoginInfoAsync();
           
            if (loginInfo == null)
                return RedirectToAction("Login");
            else
            {
                Microsoft.AspNetCore.Identity.SignInResult loginResult = await _signInManager.ExternalLoginSignInAsync(loginInfo.LoginProvider, loginInfo.ProviderKey, true);
                if (loginResult.Succeeded)
                    return Redirect(ReturnUrl);
                else
                {
                   
                    User user = new User
                    {
                        Email = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value,
                        UserName = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value
                    };
                    IdentityResult createResult = await _userManager.CreateAsync(user);
                    if (createResult.Succeeded)
                    {
                        
                        IdentityResult addLoginResult = await _userManager.AddLoginAsync(user, loginInfo);
                        if (addLoginResult.Succeeded)
                        {
                            await _signInManager.SignInAsync(user, true);
                            return Redirect(ReturnUrl);
                        }
                    }

                }
            }
            return Redirect(ReturnUrl);
        }

        public IActionResult GoogleLogin(string ReturnUrl)
        {
            string redirectUrl = Url.Action("ExternalResponse", "Account", new { ReturnUrl = ReturnUrl });
            AuthenticationProperties properties = _signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);
            return new ChallengeResult("Google", properties);
        }

        public async Task<IActionResult> ExternalResponse(string ReturnUrl = "/")
        {
            ExternalLoginInfo loginInfo = await _signInManager.GetExternalLoginInfoAsync();

            if (loginInfo == null)
                return RedirectToAction("Login");
            else
            {
                Microsoft.AspNetCore.Identity.SignInResult loginResult = await _signInManager.ExternalLoginSignInAsync(loginInfo.LoginProvider, loginInfo.ProviderKey, true);
                if (loginResult.Succeeded)
                    return Redirect(ReturnUrl);
                else
                {

                    User user = new User
                    {
                        Email = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value,
                        UserName = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value
                    };
                    IdentityResult createResult = await _userManager.CreateAsync(user);
                    if (createResult.Succeeded)
                    {
                        
                        IdentityResult addLoginResult = await _userManager.AddLoginAsync(user, loginInfo);
                        if (addLoginResult.Succeeded)
                        {
                            await _signInManager.SignInAsync(user, true);
                            return Redirect(ReturnUrl);
                        }
                    }

                }
            }
            return Redirect(ReturnUrl);
        }
    }
}
