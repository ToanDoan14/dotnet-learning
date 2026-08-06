Console.WriteLine("Nhập tên:");
string name = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Nhập điểm:");
double score = double.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Xin Chào {name}");

Console.WriteLine();

if(score >= 8 && score <= 10)
{
    Console.WriteLine("Xếp loại: Giỏi");
} 
else if(score >= 6.5)
{
    Console.WriteLine("Xếp loại: Khá");
}
else if(score >= 5)
{
    Console.WriteLine("Xếp loại: Trung Bình");
}
else
{
    Console.WriteLine("Xếp loại: Yếu");
}