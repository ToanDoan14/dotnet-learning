int choice;

do
{
    Console.WriteLine("\n=== MENU ===");
    Console.WriteLine("\n1.Xem thông tin");
    Console.WriteLine("\n2.Cài đặt");
    Console.WriteLine("\n3.Thoát");

    Console.WriteLine("Người dùng nhập:");
    if ( int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Nguoi dung nhap thanh cong");
    }
    else
    {
        Console.WriteLine("Cau truc chua hop ly, vui long nhap lai");
        continue;
    }

    switch (choice)
    {
        case 1:
            Console.WriteLine("Ban dang xem thong tin");
            break;

        case 2:
            Console.WriteLine("Ban dang o cai dat");
            break;

        case 3:
            Console.WriteLine("Dang thoat chuong trinh");
            break;

        default:
            Console.WriteLine("Lua chon khong hop le, vui long nhap lai");
            break;

    }
} while (choice != 3);

Console.WriteLine("Ban da thoat chuong trinh");