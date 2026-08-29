// ============================================================
// Lab 03 - Gioi thieu ve Controller trong ASP.NET Core MVC
// Sinh vien: Nguyen Van Hiep - MSSV: 2410900035 - Lop: K24CNT1
// Hoc phan: Phat trien ung dung voi cong nghe .NET
// ============================================================
using Microsoft.AspNetCore.Mvc;
using lab03.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab03.Controllers
{
    public class AccountController : Controller
    {
        // Hiển thị danh sách các account có đăng ký
        public IActionResult Index()
        {
            // Danh sách Account (mock data)
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name = "Hoang Anh",
                    Email = "anh@gmail.com",
                    Phone = "0986456789",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/02.png"),
                    Gender = 1,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Truong Giang",
                    Email = "giang@gmail.com",
                    Phone = "0986456789",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/03.png"),
                    Gender = 1,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Hoang Thuy",
                    Email = "thuy@gmail.com",
                    Phone = "0986456789",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/04.png"),
                    Gender = 0,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                }
            };

            // Gửi danh sách account qua view
            ViewBag.Accounts = accounts;
            return View();
        }

        // Định nghĩa url và tên cho action
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            // Danh sách Account như trên Action Index
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name = "Hoang Anh",
                    Email = "anh@gmail.com",
                    Phone = "0986456789",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/02.png"),
                    Gender = 1,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Truong Giang",
                    Email = "giang@gmail.com",
                    Phone = "0986456789",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/03.png"),
                    Gender = 1,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Hoang Thuy",
                    Email = "thuy@gmail.com",
                    Phone = "0986456789",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/04.png"),
                    Gender = 0,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                }
            };

            // LINQ truy xuất dữ liệu 1 đối tượng trong danh sách theo Id
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);

            // Gửi đối tượng account qua view
            ViewBag.account = account;
            return View();
        }
    }
}
