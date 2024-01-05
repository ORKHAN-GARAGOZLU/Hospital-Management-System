using Lumina_Hospital.Entities.AppUser;
using Lumina_Hospital.ViewModel.Admin.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index(string search)
        {
            var users = search == null ? _userManager.Users.ToList() : _userManager.Users
               .Where(u => u.FullName.ToLower().Contains(search.ToLower())).ToList();

            return View(users);
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(UserCreateVM userVM)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = userVM.UserName,
                    Email = userVM.Email,
                    FullName = userVM.FullName
                };

                var result = await _userManager.CreateAsync(user, userVM.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Member");

                    return RedirectToAction("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(userVM);

        }


        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            await _userManager.DeleteAsync(user);

            return RedirectToAction("index");
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null) return NotFound();


            var user = await _userManager.FindByIdAsync(id);

            if (user == null) return NotFound();

            UserEditVM editUserVM = new()
            {
                UserName = user.UserName,
                Email = user.Email,
                FullName = user.FullName
                
            };

            return View(editUserVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, UserEditVM editUserVM)
        {
            if (id != editUserVM.Id) return NotFound();

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(id);

                if (user == null) return NotFound();

                user.UserName = editUserVM.UserName;
                user.Email = editUserVM.Email;
                user.FullName = editUserVM.FullName;

                var isOldPasswordValid = await _userManager.CheckPasswordAsync(user, editUserVM.OldPassword);

                if (!isOldPasswordValid)
                {
                    ModelState.AddModelError("", "Old password is wrong");
                    return View(editUserVM);
                }

                if (!string.IsNullOrEmpty(editUserVM.NewPassword))
                {
                    var newPasswordHash = _userManager.PasswordHasher.HashPassword(user, editUserVM.NewPassword);
                    user.PasswordHash = newPasswordHash;
                }

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }



            return View(editUserVM);
        }

        public async Task<IActionResult> Detail(string id)
        {
            if (id == null) return NotFound();

            var user = await _userManager.FindByIdAsync(id);

            return user is null ? BadRequest() : View(user);
        }
    }
}
