namespace ProjectManagementWinApp_NguyenQuangVinh
{
    public class TruyenTranh
    {
        public int MaTruyen { get; set; }
        public string NamXuatBan { get; set; }
        public string TacGia { get; set; }
        public string TenTruyen { get; set; }
        public string NhaXuatBan { get; set; }
        public int SoLuong { get; set; }

        public TruyenTranh(int matruyen, string nxb, string tacgia, string tentruyen, string nhaxb,
            int soluong)
        {
            this.MaTruyen = matruyen;
            this.NamXuatBan = nxb;
            this.TacGia = tacgia;
            this.TenTruyen = tentruyen;
            this.NhaXuatBan = nhaxb;
            this.SoLuong = soluong;
        }
    }
}
