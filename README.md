# EasySign
A graphical user interface (Winforms) to easily sign Executable and DLL content using the Signtool.exe provided in the Windows SDK.

> Working title: Signtool UI

## Some questions that are frequented
### Where is the Signtool.exe file located?
This depends on the version of your SDK installation.
Check it by following these steps:
* Open a *Visual Studio Developer Command Prompt*
* Type _where signtool.exe_
* Copy the path to the file

### What is a PFX file?
The PFX is the certificate you want to use to sign your binaries. Signing them ensures other people that it's the original file released by you/your company and proves that no-one has tampered with it.
> _But remember kids! No security is strong enough_ ;-)

### Do I need a timestamp server?
Nope, but it you can use one when it is provided by your certificate authority.

## System requirements
* .NET Framework 4.0+
* Windows SDK or a Visual Studio installation containing Signtool.exe

## What about the [Codeplex](https://easysign.codeplex.com/) project?
Signtool UI began on Codeplex in 2013, but when a pull-request was discovered a year after date without notification - it was time to head to Github, where the rest of the world is hanging out.