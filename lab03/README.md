# Lab 03 - Giới thiệu về Controller (ASP.NET Core MVC)

**Bài làm theo đúng source hướng dẫn của thầy:** https://github.com/tvchung/k24cnt1_netcore.git (project `lab03`)

## 📋 Thông tin sinh viên

| Thông tin | Chi tiết |
|-----------|----------|
| **Mã sinh viên** | 2410900035 |
| **Họ và tên** | Nguyễn Văn Hiệp |
| **Lớp** | K24CNT1 |
| **Học phần** | Phát triển ứng dụng với công nghệ .NET |

## Nội dung demo (giống hệt bài giảng)

| # | Nội dung | File | URL test |
|---|----------|------|----------|
| 1 | HomeController mặc định (Index, Privacy, Error) | `Controllers/HomeController.cs` | `/` |
| 2 | Product Controller — truyền dữ liệu ra View bằng **ViewBag / ViewData / TempData** | `Controllers/TvcProductController.cs` | `/TvcProduct/Index` |
| 3 | Product — **mock data** model `TvcProduct` truyền ra View qua ViewData + ViewBag | `Controllers/TvcProductController.cs` | `/TvcProduct/GetProduct` |
| 4 | Model `TvcProduct`: ProductId, ProductName, YearRelease, Price | `Models/TvcProduct.cs` | — |
| 5 | View hiển thị dữ liệu từ ViewBag/ViewData/TempData | `Views/TvcProduct/Index.cshtml` | `/TvcProduct/Index` |
| 6 | View hiển thị object từ ViewData (`productVD`) + ViewBag (`productVB`) | `Views/TvcProduct/GetProduct.cshtml` | `/TvcProduct/GetProduct` |

## Cách chạy

### Cách 1 — Visual Studio
1. Mở thư mục `lab03` (file `lab03.csproj`)
2. F5 — trình duyệt mở `http://localhost:5011`

### Cách 2 — Command line
```bash
cd lab03
dotnet restore
dotnet run
```
Mở trình duyệt: `http://localhost:5011`

## Cấu trúc thư mục
```
lab03/
├── Controllers/
│   ├── HomeController.cs
│   └── TvcProductController.cs
├── Models/
│   ├── ErrorViewModel.cs
│   └── TvcProduct.cs
├── Views/
│   ├── Home/Index.cshtml, Privacy.cshtml
│   ├── TvcProduct/Index.cshtml, GetProduct.cshtml
│   └── Shared/_Layout.cshtml, Error.cshtml...
├── wwwroot/  (bootstrap, jquery, css)
├── Program.cs
├── lab03.csproj  (.NET 8)
└── appsettings.json
```

## Ghi chú
- Code giữ nguyên 100% theo source của thầy (để khớp bài giảng)
- Chạy đúng trên .NET 8 SDK
