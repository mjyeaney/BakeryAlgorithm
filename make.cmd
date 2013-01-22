@echo off

pushd "%~dp0"

set _csc_=C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe

@echo Compiling code...
%_csc_% /out:.\bin\bakery.exe /target:exe /recurse:*.cs /debug /nologo 
@echo Done!!!
 
popd
