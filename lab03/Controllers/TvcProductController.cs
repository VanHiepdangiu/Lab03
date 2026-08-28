// ============================================================
// Lab 03 - Gioi thieu ve Controller trong ASP.NET Core MVC
// Sinh vien: Nguyen Van Hiep - MSSV: 2410900035 - Lop: K24CNT1
// Hoc phan: Phat trien ung dung voi cong nghe .NET
// ============================================================
using Microsoft.AspNetCore.Mvc;
using lab03.Models;

namespace lab03.Controllers
{
    public class TvcProductController : Controller
    {
        public IActionResult Index()
        {
            // Đưa dữ liệu ra view

            ViewBag.name = "Nguyễn Văn Hiệp";
            ViewData["address"] = "SV NTU";
            TempData["UNI"] = "Trường Đại Học Nguyễn Trãi";

            return View();
        }

        // chi tiết sản  phẩm
        public IActionResult GetProduct()
        {
            //Mock data
            TvcProduct tvcProduct = new TvcProduct()
            {
                ProductId="P001",
                ProductName="Laptop Dell Vostro",
                YearRelease=2024,
                Price=12000000,
            };

            ViewData["productVD"]=tvcProduct;
            ViewBag.productVB = tvcProduct;

            return View();
        }
    }
}
