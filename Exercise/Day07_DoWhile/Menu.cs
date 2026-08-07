int choice;

do
{
    Console.WriteLine("\n=== MENU ===");
    Console.WriteLine("\n1.Xem thông tin");
    Console.WriteLine("\n2.Cài đặt");
    Console.WriteLine("\n3.Thoát");

    Console.WriteLine("Người dùng nhập:");
    choice = int.Parse(Console.ReadLine());

    if(choice == 1)
    {
        Console.WriteLine("Bạn đang xem thông tin.");
    }
    else if (choice == 2)
    {
        Console.WriteLine("Bạn đang ở phần cài đặt");
    }
    else if(choice == 3)
    {
        Console.WriteLine("Đang thoát chương trình...");
    }
    else
    {
        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập đúng số!");
    }
} 
while(choice != 3);

Console.WriteLine("Bạn đã thoát chương trình");