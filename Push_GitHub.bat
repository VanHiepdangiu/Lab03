@echo off
chcp 65001 >nul
title Push lab03 len GitHub - VanHiepdangiu (2410900035)
echo ================================================
echo   DAY CODE LEN GITHUB - Lab 03 - lab03
echo   SV: Nguyen Van Hiep - MSSV: 2410900035
echo   Repo: https://github.com/VanHiepdangiu/LabMVC
echo ================================================
echo.
echo [1/5] Kiem tra git...
where git >nul 2>&1
if errorlevel 1 (
    echo KHONG TIM THAY GIT! Cai git tai: https://git-scm.com/download/win
    pause
    exit /b
)
echo OK - da co git.
echo.

cd /d "%~dp0"

if exist ".git" (
    echo Da co git repo san - skip git init.
    echo.
) else (
    echo [2/5] Khoi tao git repo...
    git init -b main
    echo.
)

echo [3/5] Them toan bo file vao commit...
git add .
git commit -m "Lab 03: Gioi thieu ve Controller trong ASP.NET Core MVC"
echo.

echo [4/5] Gan remote GitHub...
git branch -M main
git remote remove origin 2>nul
git remote add origin https://github.com/VanHiepdangiu/LabMVC.git
echo.

echo [5/5] Push len GitHub...
echo.
echo *** QUAN TRONG: Cua so dang nhap se hien len ***
echo     - User: VanHiepdangiu
echo     - Password: NHAP PERSONAL ACCESS TOKEN (khong phai mat khau)
echo       Tao token: github.com - Settings - Developer settings
echo       - Personal access tokens - Tokens (classic) - Generate new
echo       - Tich chon "repo" - Generate - Copy token
echo.
git push -u origin main
echo.
echo ================================================
if errorlevel 1 (
    echo THAT BAI! Doc lai huong dan phia tren va chay lai.
) else (
    echo THANH CONG! Link nap bai:
    echo   https://github.com/VanHiepdangiu/LabMVC
)
echo ================================================
pause
