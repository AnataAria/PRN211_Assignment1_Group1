using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectManagementWinApp_NguyenQuangVinh
{
    public class DanhSachTruyenTranh
    {
        private LinkedList<TruyenTranh> tt;
        public int SoPhanTu { get { return tt.Count; } }

        public DanhSachTruyenTranh()
        {
            tt = new LinkedList<TruyenTranh>();
        }

        public TruyenTranh LayThongTin(int matruyen)
        {
            foreach (TruyenTranh truyentranh in tt)
            {
                if (truyentranh.MaTruyen == matruyen)
                {
                    return truyentranh;
                }
            }
            return null;
        }

        public bool ThemTruyenTranh(TruyenTranh item)
        {
            if (LayThongTin(item.MaTruyen) != null)
            {
                MessageBox.Show("Mã truyện đã tồn tại!", "Quản lý thông tin truyện tranh - Lỗi dữ liệu", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return false;
            }
            else
            {
                tt.AddLast(item);
            }
            return true;
        }
        public bool XoaTruyenTranh(int matruyen)
        {
            TruyenTranh truyen = LayThongTin(matruyen);
            if (truyen == null)
            {
                return false;
            }
            else
            {
                tt.Remove(truyen);
            }
            return true;
        }

        public TruyenTranh LayThongTinTuViTri(int index)
        {
            if (index < 0 || index >= SoPhanTu)
            {
                return null;
            }
            else
            {
                LinkedListNode<TruyenTranh> tam = tt.First;
                for (int i = 0; i < index; i++)
                {
                    tam = tam.Next;
                }
                return tam.Value;
            }
        }
    }
}

