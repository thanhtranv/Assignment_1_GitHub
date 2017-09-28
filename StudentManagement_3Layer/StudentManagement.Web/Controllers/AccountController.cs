using StudentManagement.Business.Contracts;
using StudentManagement.Business.Dtos;
using StudentManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement.Web.Controllers
{
    public class AccountController : Controller
    {
        private IUserBusinessService userService;
        private IRoleBusinessService roleService;

        public AccountController(IUserBusinessService service)
        {
            userService = service;
        }

        //// GET: Account
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegistrationViewModel registerModel)
        {
            //var total = 0;
            int us = 0;
            //var existObj = userService.SearchUserByName(registerModel.Username, 1, 1, out total);
            //var existObj = from s in userService.GetAllUsers()
            //               select s;
            //if (!String.IsNullOrEmpty(registerModel.Username))
            //{
            //    existObj = existObj.Where(s => s.Username.ToUpper().Contains((registerModel.Username.ToUpper())));
            //}
            try
            {
                UserDto user = new UserDto();
                user.Username = registerModel.Username;
                user.Password = registerModel.Password;
                user.Phone = registerModel.Phone;
                user.Email = registerModel.Email;
                user.Address = registerModel.Address;
                user.Gender = registerModel.Gender;
                user.Image = registerModel.Image;
                user.IDRole = new Guid(us, 0, 0, new byte[8]);


                //if (existObj.Count()==0)
                //{
                    if (ModelState.IsValid)
                    {
                        userService.InsertUser(user);
                        return Content("<script>alert('Successfully registered')</script>");
                }
                //}
            }
            catch (DataException)
            {

                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View();
        }

        //public ActionResult FillRoleName()
        //{
        //    RoleViewModel fillrole = new RoleViewModel();
        //    fillrole.Drp_RoleNames = (from RoleDto in RoleDto
        //                              select new SelectListItem()
        //                              {
        //                                  Text = 
        //                              })
        //}

        public ActionResult Login(LoginViewModel loginModel)
        {
            int total = 0;
            var user = userService.
            if (user.Count()!=0)
            {
                if ()
                {

                }
            }
        }
}