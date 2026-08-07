string username = "admin";
string password = "123456";
int maxAttempts = 3;

Console.WriteLine("Nhập tên đăng nhập:");
string name = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Nhập mật khẩu:");
string pass = Console.ReadLine();

while((username != name || password != pass) && maxAttempts >= 0)
{
    Console.WriteLine("Sai tài khoản hoặc mật khẩu, vui lòng nhập lại");

    Console.WriteLine("\nNhập tên đăng nhập:");
    name = Console.ReadLine();

    Console.WriteLine("\nNhập mật khẩu:");
    pass = Console.ReadLine();

    Console.WriteLine($"Bạn còn {--maxAttempts} lần thử");
    Console.WriteLine("Bạn đã hết số lần đăng nhập");
}

Console.WriteLine("Đăng nhập thành công!");
