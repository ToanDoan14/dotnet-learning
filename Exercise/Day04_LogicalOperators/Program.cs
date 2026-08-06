Console.WriteLine("XÉT DUYỆT HỌC BỔNG");

Console.WriteLine("Nhập tên:");
string name = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Nhập tuổi của bạn:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Nhập điểm của bạn:");
double score = double.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Chào bạn {name}");

if (score > 0 || score < 10)
{
    if (age >= 18 && score >= 8)
    {
        Console.WriteLine("Chúc mừng!");
    
        Console.WriteLine();

        Console.WriteLine("Bạn đủ điều kiện nhận học bổng.");
    }
    else
    {
        Console.WriteLine("Rất tiếc!");
    
        Console.WriteLine();

        Console.WriteLine("Bạn chưa đủ điều kiện nhận học bổng.");
    }
}




