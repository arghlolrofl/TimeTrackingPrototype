@echo off
SETLOCAL

cls

.paket\paket.bootstrapper.exe
if errorlevel 1 (
  exit /b %errorlevel%
)

.paket\paket.exe restore
if errorlevel 1 (
  exit /b %errorlevel%
)

SET FAKE_PATH=packages\FAKE\tools\Fake.exe

IF [%1]==[] (
    "%FAKE_PATH%" "build.fsx" "RunTest" 
) ELSE (
    "%FAKE_PATH%" "build.fsx" %* 
)