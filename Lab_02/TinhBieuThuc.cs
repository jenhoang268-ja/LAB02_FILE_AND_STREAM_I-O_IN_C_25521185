using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Lab_02
{
    public class TinhBieuThuc
    {
        private readonly string chuoi;
        private int viTri;

        public TinhBieuThuc(string bieuThuc)
        {
            chuoi = bieuThuc;
            viTri = 0;
        }

        public double Tinh()
        {
            double ketQua = DocCongTru();

            BoQuaKhoangTrang();

            if (viTri < chuoi.Length)
            {
                throw new FormatException(
                    "Ký tự không hợp lệ tại vị trí " + (viTri + 1));
            }

            if (double.IsNaN(ketQua) || double.IsInfinity(ketQua))
            {
                throw new ArithmeticException("Kết quả vượt phạm vi tính toán.");
            }

            return ketQua;
        }

        private void BoQuaKhoangTrang()
        {
            while (viTri < chuoi.Length &&
                   char.IsWhiteSpace(chuoi[viTri]))
            {
                viTri++;
            }
        }

        private bool LayKyTu(char kyTu)
        {
            BoQuaKhoangTrang();

            if (viTri < chuoi.Length && chuoi[viTri] == kyTu)
            {
                viTri++;
                return true;
            }

            return false;
        }

        private double DocCongTru()
        {
            double ketQua = DocNhanChia();

            while (true)
            {
                if (LayKyTu('+'))
                {
                    ketQua += DocNhanChia();
                }
                else if (LayKyTu('-'))
                {
                    ketQua -= DocNhanChia();
                }
                else
                {
                    break;
                }
            }

            return ketQua;
        }

        private double DocNhanChia()
        {
            double ketQua = DocThanhPhan();

            while (true)
            {
                if (LayKyTu('*'))
                {
                    ketQua *= DocThanhPhan();
                }
                else if (LayKyTu('/'))
                {
                    double soChia = DocThanhPhan();

                    if (soChia == 0)
                    {
                        throw new DivideByZeroException(
                            "Không được chia cho 0.");
                    }

                    ketQua /= soChia;
                }
                else
                {
                    break;
                }
            }

            return ketQua;
        }

        private double DocThanhPhan()
        {
            // Xử lý dấu đứng trước số hoặc ngoặc.
            if (LayKyTu('+'))
            {
                return DocThanhPhan();
            }

            if (LayKyTu('-'))
            {
                return -DocThanhPhan();
            }

            // Xử lý biểu thức trong ngoặc.
            if (LayKyTu('('))
            {
                double ketQua = DocCongTru();

                if (!LayKyTu(')'))
                {
                    throw new FormatException("Thiếu dấu ngoặc đóng ).");
                }

                return ketQua;
            }

            return DocSo();
        }

        private double DocSo()
        {
            BoQuaKhoangTrang();

            int batDau = viTri;

            while (viTri < chuoi.Length &&
                   ((chuoi[viTri] >= '0' && chuoi[viTri] <= '9') ||
                    chuoi[viTri] == '.'))
            {
                viTri++;
            }

            string phanSo = chuoi.Substring(batDau, viTri - batDau);

            double giaTri;

            if (!double.TryParse(
                phanSo,
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out giaTri))
            {
                throw new FormatException(
                    "Số không hợp lệ tại vị trí " + (batDau + 1));
            }

            return giaTri;
        }
    }
}
