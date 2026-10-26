<h1 align="center">📂 LAB 2 – FILE AND STREAM I/O IN C#</h1>

<p align="center">
  <em>Bài thực hành C# Windows Forms về đọc ghi tệp, xử lý dữ liệu và quản lý thư mục.</em>
</p>

<p align="center">
  <a href ="https://learn.microsoft.com/vi-vn/dotnet/csharp/" target="_blank" rel="noopener noreferrer">
    <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  </a>
   <a href ="https://dotnet.microsoft.com/" target="_blank" rel="noopener noreferrer">
     <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET" />
  </a>
  <a href ="https://learn.microsoft.com/vi-vn/dotnet/desktop/winforms/" target="_blank" rel="noopener noreferrer">
     <img src="https://img.shields.io/badge/Windows_Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms" />
  </a>
  <a href="https://www.sqlite.org/">
     <img src="https://img.shields.io/badge/SQLite-003B57?style=for-the-badge&logo=sqlite&logoColor=white" alt="SQLite">
  </a>
  <a href ="https://git-scm.com/" target="_blank" rel="noopener noreferrer">
     <img src="https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white" alt="Git" />
  </a>
  <a href ="https://github.com/jenhoang268-ja/LAB02_FILE_AND_STREAM_I-O_IN_C_25521185" target="_blank" rel="noopener noreferrer">
     <img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub" />
  </a>
</p>

---

## 👩‍💻 Thông tin sinh viên

| Nội dung | Thông tin |
| :--- | :--- |
| **Họ và tên** | Trương Vũ Hoàng Ngân |
| **MSSV** | 25521185 |
| **Môn học** | Lập trình mạng căn bản |
| **Bài thực hành** | Lab 2 – File and Stream I/O in C#|

---

## 📖 Giới thiệu

Ứng dụng tập hợp các bài thực hành Lab 2 trên một giao diện Windows Forms. Người dùng chọn bài tập từ form chính để thực hiện các chức năng từng bài tương ứng.

<img width="653" height="374" alt="Ảnh form chính" src="https://github.com/user-attachments/assets/27a509d0-aae1-4115-9f61-3e4cac8e6525" />


Nội dung thực hành:

- 📄 **Bài 1 — Đọc và ghi file**
- 🔍 **Bài 2 — Đọc thông tin file .txt**
- 🧮 **Bài 3 — Đọc, ghi file và tính toán**
- 🎓 **Bài 4 — Đọc và ghi file sử dụng BinaryFormatter (JsonSerializer)**
- 🎬 **Bài 5 — Quản lý phòng vé**
- 🍜 **Bài 6 — Hôm nay ăn gì?**
- 📁 **Bài 7 - Duyệt thư mục**

---

## 🛠️ Công nghệ và công cụ

| Thành phần | Công nghệ sử dụng |
| :--- | :--- |
| **Ngôn ngữ lập trình** | C# |
| **Giao diện** | Windows Forms |
| **Môi trường phát triển** | Visual Studio trên Windows |
| **Thao tác tệp và thư mục** | `System.IO` |
| **Xử lý hình ảnh** | `System.Drawing` |
| **Cơ sở dữ liệu** | SQLite |
| **Thư viện truy cập SQLite** | `System.Data.SQLite` |
| **Quản lý phiên bản** | Git và GitHub |

---

## 🚀 Hướng dẫn cài đặt và chạy

### 1. Tải mã nguồn

Tại trang repository:

1. Nhấn **Code**.
2. Chọn **Download ZIP**.
3. Giải nén vào thư mục trên máy.

Có thể sử dụng **Git Clone** với URL của repository để tải mã nguồn.

### 2. Chuẩn bị môi trường

- Sử dụng hệ điều hành **Windows**.
- Cài **Visual Studio** cùng workload **.NET desktop development**.
- Cài .NET SDK tương ứng với phiên bản khai báo trong tệp `.csproj`.
- Sử dụng phiên bản Visual Studio hỗ trợ tệp solution `.slnx`.

### 3. Mở và chạy chương trình

1. Mở tệp **`Lab_02.slnx`** bằng Visual Studio.
2. Khôi phục các gói NuGet của solution.
3. Chuột phải project **Lab_02** → **Set as Startup Project**.
4. Chọn **Build → Build Solution**.
5. Nhấn **F5** hoặc **Ctrl + F5**.
6. Tại form chính, chọn bài tập cần sử dụng.

> [!NOTE]
> Cần khôi phục các gói NuGet trước khi chạy, đặc biệt là thư viện SQLite dùng trong Bài 6.

---

## 📚 NỘI DUNG THỰC HÀNH

### 📄 Bài 1 — Đọc và ghi file văn bản

<img width="644" height="359" alt="Ảnh bài 1" src="https://github.com/user-attachments/assets/b6105556-1e60-428e-9258-14405a28b01b" />

#### 🎯 Nội dung thực hành

- Đọc toàn bộ nội dung từ file `input1.txt`.
- Hiển thị nội dung đọc được lên giao diện.
- Chuyển toàn bộ nội dung sang chữ in hoa.
- Ghi nội dung sau khi chuyển đổi vào file `output1.txt`.

#### 🛠️ Cách thực hiện

- Sử dụng `StreamReader` với mã hóa UTF-8 và phương thức `ReadToEnd()` để đọc toàn bộ file.
- Hiển thị nội dung trong ô `rtbKQ`.
- Sử dụng `ToUpper()` để chuyển nội dung sang chữ in hoa.
- Sử dụng `StreamWriter` với mã hóa UTF-8 để ghi kết quả.
- Xử lý lỗi đọc và ghi file bằng `try-catch`.

#### ▶️ Hướng dẫn sử dụng

1. Chuẩn bị file `input1.txt` trong cùng thư mục với file thực thi của chương trình, thường là `bin/Debug/net10.0-windows`.
2. Mở **Bài 1** từ giao diện chính.
3. Nhấn **ĐỌC FILE** để hiển thị nội dung lên giao diện.
4. Sau khi đọc thành công, nút **GHI FILE** được bật.
5. Nhấn **GHI FILE** để chuyển nội dung thành chữ in hoa và lưu vào `output1.txt`.
6. Xem đường dẫn trong thông báo và mở file đầu ra để kiểm tra.

> [!NOTE]
> - Nút **GHI FILE** bị vô hiệu hóa khi vừa mở form và chỉ được bật sau khi đọc file thành công.
> - File `output1.txt` được tạo nếu chưa tồn tại; nếu đã tồn tại, nội dung cũ sẽ bị ghi đè.
> - Nội dung trên giao diện vẫn giữ nguyên sau khi ghi; chữ in hoa được lưu trong file đầu ra.
> - Nếu không đọc hoặc ghi được file, chương trình hiển thị thông báo lỗi.

### 🔍 Bài 2 — Đọc thông tin một file .txt

<img width="1082" height="462" alt="Ảnh bài 2" src="https://github.com/user-attachments/assets/a7280f46-54c3-48a1-b84a-42172e96a2ec" />

#### 🎯 Nội dung thực hành

- Chọn file văn bản bằng hộp thoại `OpenFileDialog`.
- Đọc và hiển thị nội dung của file.
- Hiển thị tên file, kích thước và đường dẫn đầy đủ.
- Thống kê số dòng, số từ và số ký tự.

#### 🛠️ Cách thực hiện

- Sử dụng `OpenFileDialog` để chọn một file `.txt` có tồn tại.
- Sử dụng `StreamReader` với mã hóa UTF-8 để đọc toàn bộ nội dung.
- Sử dụng `FileInfo` để lấy kích thước và đường dẫn đầy đủ.
- Sử dụng `StringReader.ReadLine()` để đếm số dòng.
- Sử dụng biểu thức chính quy `\S+` để đếm các cụm ký tự không chứa khoảng trắng, được xem là các từ.
- Sử dụng `noiDung.Length` để đếm số ký tự.
- Hiển thị kết quả trên các ô thông tin và nội dung trong `RichTextBox`.
- Xử lý lỗi đọc file bằng `try-catch`.

#### ▶️ Hướng dẫn sử dụng

1. Mở **Bài 2** từ giao diện chính.
2. Nhấn nút **Read** để mở hộp thoại chọn file.
3. Chọn một file `.txt` → nhấn **Open**.
4. Xem nội dung và các thông tin thống kê trên giao diện.
5. Nhấn **Read** lần nữa nếu muốn chọn file khác.
6. Nhấn **Exit** để đóng cửa sổ bài tập.

> [!NOTE]
> - Có thể chọn file ở bất kỳ thư mục nào có quyền truy cập.
> - Mỗi lần chỉ chọn một file `.txt`.
> - File rỗng có số dòng, số từ và số ký tự đều bằng `0`.
> - Kích thước file theo byte có thể khác số ký tự, đặc biệt với văn bản tiếng Việt mã hóa UTF-8.
> - Chương trình chỉ đọc file, không chỉnh sửa nội dung file gốc.

### 🧮 Bài 3 — Đọc, ghi file và tính toán

<img width="786" height="476" alt="Ảnh bài 3" src="https://github.com/user-attachments/assets/d48db8e9-cd31-433c-ac7c-05c11629a28f" />

#### 🎯 Nội dung thực hành

- Đọc các biểu thức từ file `input3.txt`.
- Xử lý các phép toán cộng, trừ, nhân, chia và dấu ngoặc đơn.
- Tính toán theo thứ tự ưu tiên của các phép toán.
- Hiển thị kết quả trên giao diện.
- Ghi kết quả vào `output3.txt` theo dạng `biểu thức = kết quả`.
- Không sử dụng phương thức `DataTable.Compute` theo yêu cầu đề bài.

#### 🛠️ Cách thực hiện

- Sử dụng `StreamReader` với mã hóa UTF-8 để đọc toàn bộ file đầu vào.
- Hiển thị nội dung trong ô `rtbND`.
- Sử dụng `StringReader` để đọc từng dòng và bỏ qua các dòng trống.
- Gọi lớp `TinhBieuThuc` để tính giá trị từng biểu thức.
- Tạo kết quả theo dạng `biểu thức = kết quả`.
- Sử dụng `CultureInfo.InvariantCulture` để xuất số với dấu chấm thập phân.
- Ghi kết quả bằng `StreamWriter` với mã hóa UTF-8 và hiển thị trong ô `rtbKQ`.
- Nếu một biểu thức bị lỗi, ghi thông báo cho dòng đó và tiếp tục xử lý các dòng còn lại.

#### ▶️ Hướng dẫn sử dụng

1. Chuẩn bị file `input3.txt`, mỗi dòng chứa một biểu thức.
2. Đặt file trong cùng thư mục với file thực thi, thường là `bin/Debug/net10.0-windows`.
3. Mở **Bài 3** từ giao diện chính.
4. Nhấn **ĐỌC FILE** để hiển thị các biểu thức.
5. Sau khi đọc thành công, nút **TÍNH VÀ GHI FILE** được bật.
6. Nhấn **TÍNH VÀ GHI FILE** để xử lý các biểu thức và lưu kết quả.
7. Xem kết quả trên giao diện hoặc mở file `output3.txt` theo đường dẫn trong thông báo.

> [!NOTE]
> - Nút **TÍNH VÀ GHI FILE** bị vô hiệu hóa khi vừa mở form hoặc khi đọc file thất bại.
> - Dòng trống trong dữ liệu đầu vào được bỏ qua.
> - Biểu thức bị lỗi được ghi theo dạng `biểu thức = Lỗi: thông báo lỗi`.
> - File `output3.txt` được tạo nếu chưa tồn tại; nếu đã tồn tại, nội dung cũ sẽ bị ghi đè.
> - Khi đọc file thành công, phần kết quả cũ trên giao diện được xóa để chuẩn bị cho lần tính tiếp theo.

### 🎓 Bài 4 — Đọc và ghi file sử dụng BinaryFormatter (JsonSerializer)

<img width="1126" height="490" alt="Ảnh bài 4" src="https://github.com/user-attachments/assets/bdba292f-894d-47f3-9ad7-9931627addb3" />

#### 🎯 Nội dung thực hành

- Nhập danh sách sinh viên và ghi vào file `input4.txt` bằng `JsonSerializer`.
- Đọc lại danh sách, tính điểm trung bình của ba môn và ghi kết quả vào `output4.txt`.
- Hiển thị lần lượt từng sinh viên trên giao diện.

#### 🛠️ Cách thực hiện

- Lưu thông tin sinh viên bằng lớp `SinhVien`, gồm họ tên, MSSV, điện thoại, điểm ba môn và điểm trung bình.
- Quản lý danh sách nhập bằng `List<SinhVien>` và chuyển thành mảng khi ghi file.
- Kiểm tra dữ liệu trước khi thêm sinh viên và sau khi đọc file.
- Sử dụng `JsonSerializer.Serialize()` để chuyển danh sách thành JSON.
- Sử dụng `JsonSerializer.Deserialize<SinhVien[]>()` để khôi phục mảng sinh viên.
- Đọc và ghi file bằng mã hóa UTF-8; định dạng JSON có thụt dòng và hỗ trợ hiển thị tiếng Việt.
- Tính điểm trung bình, lưu kết quả và hiển thị thông tin từng sinh viên.
- Sử dụng **Back**, **Next** để chuyển trang.

#### ✅ Điều kiện dữ liệu

| Thông tin | Điều kiện |
|-----------|-----------|
| Họ tên | Không được để trống hoặc chỉ chứa khoảng trắng |
| MSSV | Đúng 8 chữ số, không bắt đầu bằng `0` |
| Điện thoại | Đúng 10 chữ số, bắt đầu bằng `0` |
| Điểm mỗi môn | Từ `0` đến `10`, không nhận NaN hoặc vô cực |
| Trùng MSSV | Không cho phép trong danh sách nhập hoặc dữ liệu đọc từ file |

#### ▶️ Hướng dẫn sử dụng

1. Mở **Bài 4** từ giao diện chính.
2. Nhập họ tên, MSSV, điện thoại và điểm ba môn.
3. Nhấn **Add** để thêm sinh viên vào danh sách.
4. Lặp lại thao tác để thêm các sinh viên khác.
5. Nhấn **Write** để ghi danh sách vào `input4.txt`.
6. Nhấn **Read** để đọc file, kiểm tra dữ liệu, tính điểm trung bình và ghi vào `output4.txt`.
7. Xem thông tin sinh viên và điểm trung bình ở phần kết quả.
8. Nhấn **Back** hoặc **Next** để xem sinh viên trước hoặc tiếp theo.

> [!NOTE]
> - Cần thêm ít nhất một sinh viên trước khi nhấn **Write**.
> - Nhấn **Add** chỉ thêm vào danh sách trong bộ nhớ; cần nhấn **Write** để lưu xuống file.
> - **Read** đọc dữ liệu đã lưu trong `input4.txt`, không đọc trực tiếp danh sách vừa nhập trên giao diện.
> - Hai file có phần mở rộng `.txt` nhưng nội dung được lưu dưới dạng JSON.
> - File được lưu trong thư mục chạy chương trình, thường là `bin/Debug/net10.0-windows`.
> - Mỗi lần ghi sẽ thay thế nội dung cũ của file tương ứng.
> - Điểm trung bình trên giao diện được hiển thị với hai chữ số thập phân.
> - Nhãn trang có dạng `1/3`, nghĩa là đang xem sinh viên thứ nhất trong tổng số ba sinh viên.
> - Nút **Back** bị vô hiệu hóa ở trang đầu; nút **Next** bị vô hiệu hóa ở trang cuối.
> - Chương trình thông báo khi dữ liệu không hợp lệ hoặc xảy ra lỗi đọc, ghi file.





---

## 🖼️ Tài nguyên giao diện

Các ảnh sử dụng trong ứng dụng được lưu trong thư mục **`Resources`**.

> [!IMPORTANT]
> - Giữ đầy đủ các ảnh, tệp `.resx` và mã Designer.
> - Khi đổi tên ảnh, cần cập nhật đường dẫn tham chiếu tương ứng để tránh lỗi Build hoặc lỗi mở giao diện.

---

<p align="center">
  <b> LAB 2 – LẬP TRÌNH MẠNG CĂN BẢN</b>
  <br>
  <em>Trương Vũ Hoàng Ngân · 25521185</em>
</p>
