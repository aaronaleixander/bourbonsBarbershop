using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bourbonsBarbershop.Data;
using bourbonsBarbershop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bourbonsBarbershop.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Provides access to session data for the current user.
        /// </summary>
        private readonly IHttpContextAccessor _httpAccessor;

        /// <summary>
        /// Represents the Database context
        /// </summary>
        private readonly BourbonsContext _context;

        public AccountController(BourbonsContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _httpAccessor = accessor;
        }


        // REGISTER

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                await CustomerDb.Add(_context, customer);
                TempData["Message"] = "Welcome to Bourbons.";
                return RedirectToAction("Index", "Home");
            }
            return  View(customer);
        }

        // LOGIN
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Customer customer = await CustomerDb.IsLoginValid(model, _context);
                if (customer != null)
                {
                    TempData["Message"] = "Logged in sucessfully";

                    // Create current session for the user.
                    _httpAccessor.HttpContext.Session.SetInt32("CustomerId", customer.CustomerId);
                    _httpAccessor.HttpContext.Session.SetString("FirstName", customer.FirstName);


                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Credentials Invalid
                    ModelState.AddModelError(string.Empty, "Im sorry your login was invalid.");
                }
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            _httpAccessor.HttpContext.Session.Clear();
            TempData["Message"] = " You have been logged out";
            return RedirectToAction("Index", "Home");
        }
    }
}