# Simple Injector
A simple DLL injector written in C# that injects a DLL into a running process

### How does it work?
The process of injecting a DLL into a running process is accomplished via 5 steps

* The address of the LoadLibraryA module is loaded from the Windows API (kernel32.dll)
* The handle of the chosen process is then found (using ProcessAllAccess)
* Memory is then allocated within the process for the DLL name to be written
* The name of the DLL is then written into the processes memory
* Finally, a thread is created in the process which calls the LoadLibraryA module, which in turn invokes the DLL

### How do I use Simple Injector?
* Compile the project (Change debug to release)
* Run the Simple Injector.exe file it creates in the release directory (Simple-Injector\Simple Injector\bin\Release)

### Screenshot
![alt text](https://i.imgur.com/7pPS763.png)
