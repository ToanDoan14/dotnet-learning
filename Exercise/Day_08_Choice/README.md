## DAY 8

# switch case là gì ?

switch là khả năng xử lý giữa các lựa chọn được đưa ra theo cấu trúc, với việc nằm ngoài các trường hợp đặc biệt, chúng ta cần sử dụng thêm default được sử dụng khi không khớp với giá trị case nào. Và sau khi kết thúc mỗi case, luôn nhớ cần có break để kết thúc case và thoát khỏi switch.

Ví dụ:

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

# TryParse là gì ? 

TryParse là khá niệm nhằm thử chuyển đổi kiểu dữ liệu cụ thể được đưa vào chương trình, và trả về boolean: true/false cho biết chuyển đổi có thành công hay không.

Ví dụ:

int.TryParse(Console.ReadLine(), out choice);

nếu người dùng nhập 5 ==> true , choice = 5;

nếu người dùng nhập abc ==> false;

# Điểm khác biệt của Prase và TryParse 

Parse nằm ở đây dưới tư cách chuyển đổi một chuỗi biểu diển dữ liệu thành kiểu dữ liệu tương ứng, nhưng nếu kiểu dữ liệu không hợp lệ Parse có thể gây crash chương trình. Trong khi đó TryParse lại là kiểm thử kiểu dữ liệu có hợp lý hay không và trả về true/false thay vì đưa ra exception như Parse vì chuyển đổi thất bại

# Điều hiểu rõ nhất hôm nay

Có thể sử dụng switch case nhằm vào các chương trình với nhiều điều kiện giúp tinh giảm code

# Những lỗi đã mắc

Kết thúc case không sử dụng break
Nhầm lẫn giữa Break và Continue ( Break sẽ trực tiếp kết thúc vòng lặp mà nó đang nằm trong, trong khi đó continue chỉ bỏ qua đoạn code còn lại và tiếp tục vòng lặp sau đó)
Chưa nắm được phải nhập gì sau TryParse

# Điều khó nhất hôm nay

Xác định các điều kiện và tổ chức code sao cho tường minh