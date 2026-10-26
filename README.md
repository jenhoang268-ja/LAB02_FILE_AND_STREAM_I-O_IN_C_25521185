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
- 📁 **Duyệt thư mục**

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

## 🎯 Các chức năng nổi bật

### 🎬 Bài 5 – Bán vé xem phim

Chương trình phát triển từ Bài 4 Lab 1, bổ sung thao tác với tệp theo yêu cầu Lab 2.

**Chức năng:**

- Đọc dữ liệu cấu hình phim từ tệp đầu vào.
- Chọn phim, phòng chiếu và ghế ngồi.
- Tính tiền vé và xác nhận thanh toán.
- Thống kê kết quả bán vé.
- Xuất dữ liệu ra tệp và hiển thị tiến độ.

**Cách sử dụng:**

1. Chuẩn bị tệp cấu hình đúng định dạng.
2. Nhấn nút đọc Input và chọn tệp.
3. Chọn phim, phòng chiếu và ghế.
4. Kiểm tra số tiền rồi thực hiện thanh toán.
5. Sử dụng nút thống kê hoặc xuất tệp khi cần.

> [!IMPORTANT]
> Tệp đầu vào cần đúng định dạng mà chương trình yêu cầu để dữ liệu phim được đọc chính xác.

### 🍜 Bài 6 – Hôm nay ăn gì?

Chương trình phát triển từ Bài 8 Lab 1, sử dụng SQLite để lưu món ăn, hình ảnh và thông tin người đóng góp.

| Chức năng | Mô tả |
| :--- | :--- |
| **Thêm món ăn** | Lưu tên món, ảnh và người đóng góp |
| **Hiển thị danh sách** | Hiển thị số thứ tự, tên món và người đóng góp |
| **Chọn ngẫu nhiên** | Chọn một món trong cơ sở dữ liệu |
| **Hiển thị kết quả** | Hiển thị tên món, ảnh và người đóng góp |
| **Xóa món ăn** | Xóa món đang chọn sau khi xác nhận |

**Cách sử dụng:**

1. Nhập tên món ăn.
2. Chọn người đóng góp.
3. Chọn hình ảnh cho món ăn.
4. Nhấn **Thêm** để lưu.
5. Nhấn nút tìm món để chọn ngẫu nhiên.
6. Muốn xóa, chọn món trong danh sách rồi nhấn **Xóa**.

> [!NOTE]
> Khi chưa có cơ sở dữ liệu, chương trình tạo tệp `homnayangi.db` trong thư mục chạy. Cần thêm dữ liệu trước khi sử dụng chức năng chọn ngẫu nhiên.

### 📁 Bài 7 – Duyệt thư mục và xem tệp

**Chức năng:**

- Hiển thị ổ đĩa, thư mục và tệp bằng `TreeView`.
- Nạp danh sách thư mục con và tệp khi mở rộng nút.
- Xem hình ảnh bằng `PictureBox`.
- Xem nội dung văn bản bằng `RichTextBox`.
- Thông báo khi không thể truy cập hoặc đọc dữ liệu.

**Cách sử dụng:**

1. Chọn ổ đĩa trên cây thư mục.
2. Mở rộng các nút để tìm thư mục và tệp.
3. Chọn tệp ảnh hoặc văn bản được hỗ trợ.
4. Xem nội dung trong khu vực hiển thị.

> [!TIP]
> Có thể chuẩn bị một thư mục chứa ảnh và tệp `.txt` để kiểm tra nhanh chức năng xem nội dung.

---

## 🔄 Quy trình xử lý chung

| Bước | Nội dung |
| :---: | :--- |
| **1. Nhận sự kiện** | Tiếp nhận thao tác nhấn nút hoặc chọn dữ liệu |
| **2. Đọc dữ liệu** | Lấy dữ liệu từ giao diện, tệp hoặc SQLite |
| **3. Xác thực dữ liệu** | Kiểm tra dữ liệu trống, định dạng và điều kiện xử lý |
| **4. Tính toán và xử lý** | Thực hiện yêu cầu tương ứng của bài tập |
| **5. Hiển thị kết quả** | Cập nhật giao diện, thông báo hoặc lưu kết quả |

---

## 🧪 Kiểm thử

Các nhóm trường hợp cần kiểm tra:

| Nhóm | Trường hợp kiểm thử |
| :--- | :--- |
| **Dữ liệu đầu vào** | Hợp lệ, trống, thiếu hoặc sai định dạng |
| **Đọc ghi tệp** | Tệp tồn tại, không tồn tại hoặc không thể truy cập |
| **Bán vé** | Chọn ghế, tính tiền, thanh toán và xuất kết quả |
| **Món ăn** | Thêm món, danh sách trống, chọn ngẫu nhiên và xóa món |
| **Thư mục** | Mở rộng thư mục, xem ảnh và đọc văn bản |

Chi tiết test case, kết quả thực tế và hình ảnh giao diện của tất cả bài tập được trình bày trong **báo cáo PDF nộp kèm**.

---

## 🖼️ Tài nguyên giao diện

Các ảnh sử dụng trong ứng dụng được lưu trong thư mục **`Resources`**.

> [!IMPORTANT]
> Giữ đầy đủ các ảnh, tệp `.resx` và mã Designer. Khi đổi tên ảnh, cần cập nhật đường dẫn tham chiếu tương ứng để tránh lỗi Build hoặc lỗi mở giao diện.

---

## 📌 Lưu ý khi sử dụng mã nguồn

- Ứng dụng Windows Forms chạy trên **Windows**.
- Chuẩn bị tệp đầu vào theo yêu cầu từng bài.
- Khôi phục NuGet và Build trước lần chạy đầu tiên.
- Các thư mục `bin`, `obj`, `.vs` và `.vs_backup` không cần đưa vào repository.
- Bài 6 sử dụng SQLite, không yêu cầu cài SQL Server.

---

<p align="center">
  <b>📚 LAB 2 – LẬP TRÌNH MẠNG CĂN BẢN</b>
  <br>
  <em>Trương Vũ Hoàng Ngân · 25521185</em>
</p>
