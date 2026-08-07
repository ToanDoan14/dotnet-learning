int secretNumber = 7;
int guess;
do
{
    Console.WriteLine("Người dùng nhập số:");   
    guess = int.Parse(Console.ReadLine());

    Console.WriteLine("Người dùng vui lòng nhập lại!");
} 
while(guess != secretNumber);
    Console.WriteLine("Chúc mừng, bạn đã chiến thắng!");

