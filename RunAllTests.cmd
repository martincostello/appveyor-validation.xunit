@echo off
packages\xunit.runner.console\tools\xunit.console ConsoleRunner\bin\Debug\ConsoleRunner.dll
msbuild Tests.proj /nologo /logger:"C:\Program Files\AppVeyor\BuildAgent\Appveyor.MSBuildLogger.dll"
dnx -p DNXRunner test