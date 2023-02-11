// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");

using AtmProject.Business;
using AtmProject.Entity;

AtmUserManager userManager = new AtmUserManager();
ProcessManager processManager = new ProcessManager(new Process());
string name;
string password;
string processName = "";
int id = 0;


Console.WriteLine("Kullanıcı Adı:");
name = Console.ReadLine();
Console.WriteLine("Şifreniz:");
password = Console.ReadLine();

userManager.AddUser();
if (userManager.UserRegisterControl(name, password) == false)
{
    Console.ReadKey();
}

Console.WriteLine("Yapmak istediğiniz işlemi yazın.");
processName = Console.ReadLine();


var proces = new Process
{
    Id = id + 1,
    ProcessName = processName,
    ProcessTime = DateTime.Today
};

processManager.SelectProcess(proces);


