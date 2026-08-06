# Day03

## if là gì ?

if là câu lệnh điều kiện được đặt ra để kiểm tra một điều kiện có đúng hay không.

Nếu điều kiện true chương trình sẽ chạy đoạn code bên trong if.
Nếu điều kiện false, chương trình sẽ bỏ qua và chạy các câu lệnh phía sau
Ví dụ if(age >= 18){
    Console.WriteLine("Bạn là người trưởng thành");
}

## else if dùng khi nào ?

else if được sử dụng khi có điều kiện trước không đúng và cần kiểm tra điều kiện khác.

Nếu điều kiện của if không đúng, chương trình sẽ tiếp tục kiểm tra các điều kiện else if tiếp tục từ trên xuống dưới.

## else dùng khi nào ?
else là điều kiện được thực hiện khi tất cả các điều kiện ở trên sai.
Thường được sử dụng để xử lý các trường hợp còn lại.

Ví dụ: if(score >= 8 && score <= 10)
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

## Hiểu gì về luồng thực thi của chương trình ?

Chương trình sẽ nhận dữ liệu từ người dùng.

Sau đó xử lý theo điều kiện đã được lập trình.

Cuối cùng sẽ hiển thị kết quả tương ứng.

## Điều khó nhất hôm nay là gì ?

Chưa biết cách tạo các đường phân cách đẹp hơn.
Chưa biết cách tránh lặp lại các đoạn Console.WriteLine().
Chưa biết cách tổ chức code sao cho gọn.