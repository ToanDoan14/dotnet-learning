string username = "admin";
string password = "123456";
int maxAttempts = 3;

while(maxAttempts > 0)
{   
    Console.WriteLine("Nhập tên đăng nhập:");
    string name = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("Nhập mật khẩu:");
    string pass = Console.ReadLine();
    
    if(username == name && password == pass)
    {
        Console.WriteLine("Đăng nhập thành công!");
        break;
        
    }
    
    Console.WriteLine("\nNgười dùng nhập sai tài khoản hoặc mật khẩu, vui lòng nhập lại");
    
    maxAttempts--;
    Console.WriteLine($"\nCòn {maxAttempts} lần đăng nhập");
}

if(maxAttempts == 0)
{
    Console.WriteLine("Người dùng đã hết số lần đăng nhập");
} 


