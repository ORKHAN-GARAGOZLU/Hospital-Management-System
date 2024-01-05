using Lumina_Hospital.Entities.AppUser;
using Lumina_Hospital.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _rolemanager;
        private readonly UserManager<User> _userManager;

        public RoleController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _rolemanager = roleManager;
        }

        public IActionResult Index()
        {
            return View(_rolemanager.Roles.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string roleName)
        {
            if (string.IsNullOrEmpty(roleName)) return NotFound();

            await _rolemanager.CreateAsync(new IdentityRole { Name = roleName });

            return RedirectToAction("index", "role");
        }

        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            RoleEditVM editRoleVM = new();

            editRoleVM.UserRoles = await _userManager.GetRolesAsync(user);
            editRoleVM.Roles = _rolemanager.Roles.ToList();
            editRoleVM.User = user;


            return View(editRoleVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, List<string> roles)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            var oldRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, oldRoles);
            await _userManager.AddToRolesAsync(user, roles);

            return RedirectToAction("Index", "User");
        }

    }

}
