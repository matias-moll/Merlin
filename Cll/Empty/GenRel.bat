@echo off

if exist "XX - Release" goto NoCreate

md "XX - Release"
REM md "XX - Release\Hlp"
REM md "XX - Release\Img"
REM md "XX - Release\Plg"
REM md "XX - Release\Prg"

:NoCreate


copy bin\Release\Rivn.Cll.dll "XX - Release"
pause

