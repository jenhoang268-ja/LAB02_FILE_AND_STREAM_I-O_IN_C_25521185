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

### 🎬 Bài 5 — Quản lý phòng vé

<img width="934" height="628" alt="Ảnh bài 5" src="https://github.com/user-attachments/assets/8188bfb7-d5ac-4dbd-bfa5-1a1be3393efe" />

#### 🎯 Nội dung thực hành

- Kế thừa chương trình bán vé xem phim của **Bài 4 Lab 1**.
- Bổ sung chức năng nhập cấu hình phim, ghi và đọc file `input5.txt`, thống kê theo phim và xuất kết quả vào `output5.txt`.
- Sử dụng `ProgressBar` và nhãn phần trăm để theo dõi tiến độ xuất file.

#### 📝 Các chức năng chính

- Nhập, kiểm tra và lưu cấu hình phim vào file.
- Đọc cấu hình để áp dụng tên phim, giá vé chuẩn và phòng chiếu.
- Chọn phim qua các poster và chọn phòng chiếu hợp lệ.
- Chọn hoặc bỏ chọn ghế trong sơ đồ 15 ghế mỗi phòng.
- Tính tiền theo loại ghế và xác nhận thanh toán.
- Cập nhật ghế đã mua, ngăn mua lại trong cùng phim và phòng chiếu.
- Thống kê vé đã bán, vé tồn, tỷ lệ bán và doanh thu.
- Xếp hạng phim theo doanh thu từ cao xuống thấp.
- Xuất thống kê ra file UTF-8 và hiển thị tiến độ.

#### 📥 Cấu trúc file input5.txt

Mỗi phim gồm **3 dòng liên tiếp**:

1. Tên phim.
2. Giá vé chuẩn.
3. Danh sách phòng chiếu, phân cách bằng dấu phẩy.

**Điều kiện cấu hình:**
- Tên phim phải khớp một trong bốn poster: `Đào, phở và piano`, `Mai`, `Gặp lại chị bầu`, `Tarot`.
- Không khai báo trùng tên phim.
- Giá vé phải lớn hơn `0`; nhập như `45000`, không kèm đơn vị tiền hoặc dấu phân cách hàng nghìn.
- Phòng chiếu chỉ nhận `1`, `2`, `3` và không được trùng trong cùng một phim.
- Không chèn dòng trống giữa các nhóm dữ liệu; có thể để dòng trống cuối file.

#### 💺 Loại ghế và màu hiển thị

| Loại hoặc trạng thái | Ghế áp dụng | Giá vé | Màu |
|----------------------|-------------|--------|-----|
| Vé vớt | A1, A5, C1, C5 | Giá chuẩn × 0.25 | Xanh da trời nhạt |
| Vé thường | A2, A3, A4, B1, B5, C2, C3, C4 | Giá chuẩn × 1 | Trắng khói |
| Vé VIP | B2, B3, B4 | Giá chuẩn × 2 | Vàng |
| Đang chọn | Ghế được người dùng chọn | Theo loại ghế | Xanh lá nhạt |
| Đã mua | Ghế đã thanh toán | Không thể chọn lại | Xám |

#### ▶️ Hướng dẫn sử dụng

**1. Nạp cấu hình phim**

- Mở **Bài 5** từ giao diện chính.
- Nhập hoặc chỉnh sửa dữ liệu trong ô cấu hình phim. Nếu ô đang trống khi mở form, chương trình điền dữ liệu mẫu.
- Nhấn **Ghi input5** để lưu cấu hình vào `input5.txt`.
- Nhấn **Đọc input5** để nạp và áp dụng dữ liệu đã lưu.

**2. Chọn vé**

- Nhập tên khách hàng.
- Nhấn poster để chọn phim.
- Chọn một phòng chiếu đang được bật.
- Nhấn các ghế muốn mua; nhấn lại ghế đang chọn để bỏ chọn.
- Khi đổi phim hoặc phòng, các ghế chưa thanh toán đang chọn sẽ được bỏ chọn.

**3. Thanh toán**

- Nhấn **Thanh toán**.
- Kiểm tra tên khách hàng, phim, phòng, danh sách ghế, giá từng vé và tổng tiền.
- Chọn **Có** để xác nhận hoặc **Không** để hủy thanh toán.
- Sau khi xác nhận thành công, ghế chuyển sang màu xám và doanh thu được cập nhật.
- Nhấn **OK** để đóng thông báo thành công.

**4. Xem và xuất thống kê**

- Nhấn **Thống kê** để xem bảng tổng hợp theo phim.
- Nhấn **Xuất file** để ghi thống kê vào `output5.txt`.
- Theo dõi thanh tiến trình và phần trăm từ `0%` đến `100%`.
- Khi xuất xong, bảng thống kê được cập nhật và chương trình thông báo đường dẫn file.

#### 📊 Nội dung thống kê

| Thông tin | Cách xác định |
|-----------|--------------|
| Tổng số vé | Số phòng của phim × 15 ghế |
| Vé đã bán | Tổng số ghế đã thanh toán của phim |
| Vé tồn | Tổng số vé − Vé đã bán |
| Tỷ lệ bán | Vé đã bán / Tổng số vé × 100% |
| Doanh thu | Tổng số tiền từ các giao dịch đã xác nhận |
| Xếp hạng | Doanh thu giảm dần; nếu bằng nhau, sắp theo tên phim tăng dần |

> [!NOTE]
> - Phải đọc cấu hình trước khi chọn phim và bán vé.
> - Phải nhập tên khách hàng, chọn phim, phòng và ít nhất một ghế để thanh toán.
> - Sau khi đã bán vé, chương trình không cho ghi hoặc nạp lại cấu hình trong phiên đó.
> - Khi xuất file, các thao tác thay đổi dữ liệu bị khóa và không thể đóng form cho đến khi hoàn tất.
> - Hai file được lưu trong thư mục chạy chương trình, thường là `bin/Debug/net10.0-windows`.
> - Ghi cấu hình hoặc xuất thống kê sẽ ghi đè file tương ứng.
> - Ghế đã mua và doanh thu chỉ được giữ trong bộ nhớ của phiên mở form.
> - File `output5.txt` là báo cáo thống kê, không dùng để khôi phục giao dịch khi mở lại chương trình.

### 🍜 Bài 6 — Hôm nay ăn gì?

<img width="966" height="498" alt="Ảnh bài 6" src="https://github.com/user-attachments/assets/fb8df484-564b-4c49-9bfc-df503386d04c" />

#### 🎯 Nội dung thực hành

Kế thừa chương trình chọn món ăn của **Bài 8 Lab 1**, bổ sung lưu trữ và truy vấn dữ liệu bằng SQLite.

- Chương trình cho phép thêm món ăn kèm hình ảnh, tên người đóng góp; hiển thị danh sách và chọn ngẫu nhiên một món ăn cùng thông tin liên quan.

#### 🛠️ Các chức năng chính

- **Khởi tạo dữ liệu:** Tự tạo cơ sở dữ liệu và các bảng nếu chưa tồn tại.
- **Thêm món ăn:** Nhập tên món và tên người đóng góp ngay trong phần thêm món.
- **Chọn ảnh:** Chọn ảnh minh họa và xem trước trên giao diện.
- **Lưu SQLite:** Lưu món ăn, dữ liệu ảnh và người đóng góp vào `homnayangi.db`.
- **Hiển thị danh sách:** Đọc dữ liệu và hiển thị bằng `ListView`.
- **Chọn ngẫu nhiên:** Truy vấn một món bằng `ORDER BY RANDOM() LIMIT 1`.
- **Hiển thị kết quả:** Hiển thị tên món, hình ảnh và tên người đóng góp.
- **Đánh dấu món:** Chọn dòng tương ứng với kết quả ngẫu nhiên trong danh sách.
- **Xóa món:** Xóa món đang chọn sau khi xác nhận.
- **Thoát:** Đóng cửa sổ bài tập.

#### 🗃️ Cấu trúc cơ sở dữ liệu

Dữ liệu được lưu trong file **homnayangi.db**, gồm hai bảng:

| Bảng | Trường dữ liệu | Ý nghĩa |
|------|----------------|---------|
| `NguoiDung` | `IDNCC` | Khóa chính, tự tăng |
| `NguoiDung` | `HoVaTen` | Tên người đóng góp |
| `NguoiDung` | `QuyenHan` | Quyền hạn, được gán là `Người dùng` khi thêm |
| `MonAn` | `IDMA` | Khóa chính, tự tăng |
| `MonAn` | `TenMonAn` | Tên món ăn |
| `MonAn` | `HinhAnh` | Dữ liệu ảnh, lưu dưới dạng BLOB |
| `MonAn` | `IDNCC` | Khóa ngoại liên kết với người đóng góp |

- Hai bảng liên kết thông qua `IDNCC`. Chương trình bật kiểm tra khóa ngoại trên mỗi kết nối.
- Khi thêm món, thông tin người đóng góp và món ăn được lưu trong cùng một giao dịch.
- Chỉ xác nhận lưu khi cả hai bước đều thành công.

#### ✅ Điều kiện dữ liệu

- Tên món ăn không được để trống.
- Tên người đóng góp không được để trống.
- Phải chọn ảnh hợp lệ trước khi thêm món.
- Các định dạng ảnh được chọn gồm `.jpg`, `.jpeg`, `.png` và `.bmp`.

#### ▶️ Hướng dẫn sử dụng

**1. Thêm món ăn**

1. Mở **Bài 6** từ giao diện chính.
2. Nhập tên món ăn.
3. Nhập tên người đóng góp ngay trong phần thêm món ăn.
4. Nhấn **Chọn ảnh**, chọn hình minh họa → nhấn **Mở**.
5. Kiểm tra ảnh xem trước.
6. Nhấn **Thêm món** để lưu vào cơ sở dữ liệu.
7. Kiểm tra món vừa thêm trong danh sách.

**2. Chọn món ngẫu nhiên**

1. Nhấn nút **Tìm món ăn** để chọn ngẫu nhiên một món.
2. Xem tên món, hình ảnh và người đóng góp trong phần kết quả.
3. Món được chọn sẽ được đánh dấu trong danh sách.
4. Nhấn lại để tiếp tục nhận gợi ý.

**3. Xóa món ăn**

1. Chọn một món trong danh sách.
2. Nhấn **Xóa món ăn**.
3. Chọn **Có** để xác nhận hoặc **Không** để hủy.
4. Sau khi xóa thành công, danh sách được tải lại và kết quả đang hiển thị được xóa.

**4. Thoát chương trình**

Nhấn **Thoát** để đóng cửa sổ Bài 6.

> [!NOTE]
> - Dữ liệu được giữ lại khi đóng và mở lại chương trình.
> - File `homnayangi.db` nằm trong thư mục chạy chương trình, thường là `bin/Debug/net10.0-windows`.
> - Hình ảnh được lưu trực tiếp trong cơ sở dữ liệu, không chỉ lưu đường dẫn đến ảnh gốc.
> - Cột **Số thứ tự** được đánh lại khi tải danh sách; mã món ăn vẫn được lưu nội bộ để tìm và xóa đúng món.
> - Mỗi lần thêm món, chương trình tạo một bản ghi người đóng góp mới, kể cả khi tên đã tồn tại.
> - Cho phép thêm các món trùng tên.
> - Nếu danh sách trống, chương trình yêu cầu thêm món ăn.

### 🗂️ Bài 7 - Duyệt thư mục

<img width="711" height="379" alt="Ảnh bài 7" src="https://github.com/user-attachments/assets/d87fa47b-f738-44c9-918c-9cbd70b354c4" />

#### 🎯 Nội dung thực hành

- Xây dựng ứng dụng duyệt các ổ đĩa, thư mục và file trên máy tính.
- Cho phép mở rộng thư mục bằng cách nhấn đúp chuột hoặc nhấn dấu mở rộng, đồng thời xem trước nội dung file khi chọn.

#### 🛠️ Các chức năng chính

- **Hiển thị ổ đĩa:** Liệt kê các ổ đĩa bằng `DriveInfo.GetDrives()`.
- **Duyệt cây thư mục:** Hiển thị thư mục và file bằng `TreeView`.
- **Mở thư mục:** Nhấn đúp hoặc nhấn dấu mở rộng để tải nội dung bên trong.
- **Tải khi cần:** Chỉ đọc danh sách thư mục con và file khi mở rộng nút.
- **Sắp xếp danh sách:** Sắp xếp tên không phân biệt chữ hoa, chữ thường; hiển thị thư mục trước, file sau.
- **Xem văn bản:** Đọc nội dung bằng UTF-8 và hiển thị trong `RichTextBox`.
- **Xem hình ảnh:** Hiển thị ảnh trong `PictureBox`.
- **Hiển thị tên file:** Cập nhật tiêu đề khung nội dung theo file đang chọn.
- **Thông báo lỗi:** Xử lý trường hợp không có quyền truy cập, không đọc được file hoặc định dạng chưa được hỗ trợ.

#### 📋 Định dạng hỗ trợ xem trước

| Nhóm | Phần mở rộng |
|------|--------------|
| Hình ảnh | `.jpg`, `.jpeg`, `.png`, `.bmp`, `.gif`, `.ico` |
| Văn bản và dữ liệu | `.txt`, `.csv`, `.log`, `.json`, `.xml`, `.md`, `.ini` |
| Mã nguồn | `.cs`, `.html`, `.css`, `.js`, `.sql` |

Các định dạng văn bản được hiển thị dưới dạng nội dung thuần văn bản.

#### ▶️ Hướng dẫn sử dụng

1. Mở **Bài 7** từ giao diện chính.
2. Chọn ổ đĩa trong cây thư mục.
3. Nhấn dấu mở rộng hoặc nhấn đúp vào ổ đĩa, thư mục để xem nội dung bên trong.
4. Tiếp tục mở các thư mục con để tìm file cần xem.
5. Nhấn chọn một file:
   - File ảnh được hỗ trợ sẽ hiển thị trong khung ảnh.
   - File văn bản được hỗ trợ sẽ hiển thị trong khung văn bản.
   - File chưa được hỗ trợ sẽ hiển thị thông báo kèm đường dẫn.
6. Chọn file khác để chuyển nội dung xem trước.
7. Đóng cửa sổ để kết thúc bài tập.

> [!NOTE]
> - Chỉ truy cập được các ổ đĩa và thư mục mà hệ điều hành cho phép.
> - File văn bản có kích thước tối đa `2 × 1024 × 1024` byte được xem trước.
> - Văn bản được đọc bằng UTF-8; file dùng bảng mã khác có thể hiển thị sai dấu.
> - Khi chọn thư mục hoặc file khác, nội dung xem trước cũ được xóa.
> - Ảnh được sao chép vào bộ nhớ để không giữ khóa file ảnh gốc.
> - Danh sách của thư mục đã tải không tự cập nhật khi có thay đổi từ bên ngoài; có thể đóng và mở lại form để tải lại.

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
