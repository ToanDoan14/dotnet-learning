Console.WriteLine("Chào mừng bạn đến với chương trình đầu tiên của tôi.");

Console.WriteLine("Nhập tên của bạn: ");
string name = Console.ReadLine();

Console.WriteLine("Nhập tuổi của bạn: ");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Nhập chiều cao của bạn (m): ");
float height = float.Parse(Console.ReadLine());

Console.WriteLine($"Xin chào {name}");
Console.WriteLine($"Bạn {age} tuổi");
Console.WriteLine($"Bạn cao {height} mét.");
Console.WriteLine("Chúc bạn học C# thật tốt!");

Console.WriteLine("Bạn có thích lập trình không ?");
string answer = Console.ReadLine();

Console.WriteLine($"Bạn đã trả lời {answer}");