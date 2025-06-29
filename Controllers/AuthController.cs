using Microsoft.AspNetCore.Mvc;

namespace gomokuLiveGame.Controllers
{
    public class AuthController : Controller
    {
        // 登录页面
        public IActionResult Login()
        {
            return View();
        }

        // 登录提交处理
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // 模拟验证逻辑
            if (username == "admin" && password == "123456")
            {
                ViewBag.Message = "Login successful.";
                // return RedirectToAction("Index", "Home");
            }

            ViewBag.Message = "Invalid credentials.";
            return View();
        }

        // 注册页面
        public IActionResult Register()
        {
            return View();
        }

        // 注册提交处理（目前只是跳转）
        [HttpPost]
        public IActionResult Register(string username, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                ViewBag.Message = "Passwords do not match.";
                return View();
            }

            ViewBag.Message = "Registration successful (simulated).";
            return RedirectToAction("Login");
        }
    }
}
