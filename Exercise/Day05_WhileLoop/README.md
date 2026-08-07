# Day 05

## while 

Là vòng lặp để thực hiện một đoạn code nhiều lần
Vòng lặp sẽ tiếp tục chạy khi điều kiện còn đúng và sẽ  dừng lại khi điều kiện của vòng lặp không được thoả mãn 

Ví dụ 
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

## Học được gì hôm nay ?

while loop
Cập nhật giá trị của biến trong vòng lặp
validation bằng while 
Luồng thực thi của vòng lặp

## Điều hiểu rõ nhất hôm nay

Muốn thoát khỏi vòng lặp thì điều kiện cần thay đổi, vì vậy cần nhớ cập nhật giá trị biến trong vòng lặp

Ví dụ: score = double.Prase(Console.ReadLine());

## Những lỗi đã mắc

Dùng sai điều kiện && và || 
Quên cập nhật giá trị biến trong while 
Khó hình dung luồng thực thi khi có nhiều bước

## Điều khó nhất hôm nay

thiết kế thuật toán trước khi viết code. 

Đặc biệt là bài toán đăng nhập nhiều lần vì cần nghĩ về luồng nghiệp vụ xử lý chương trình.