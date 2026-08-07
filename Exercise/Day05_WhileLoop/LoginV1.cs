string username = "admin";
string password = "123456";

Console.WriteLine("Nhập tên đăng nhập:");
string name = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Nhập mật khẩu:");
string pass = Console.ReadLine();

while(username != name || password != pass)
{
    Console.WriteLine("Sai tài khoản hoặc mật khẩu, vui lòng nhập lại");

    Console.WriteLine();

    Console.WriteLine("Nhập tên đăng nhập:");
    name = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("Nhập mật khẩu:");
    pass = Console.ReadLine();
}

Console.WriteLine("Đăng nhập thành công!");