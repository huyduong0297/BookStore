using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBookStore.Models;

namespace MVCBookStore.Models
{
    public class Giohang
    {
        //Tạo đối tượng db chứa dữ liệu từ model dbBansach đã tạo
        dbQLBansachDataContext db = new dbQLBansachDataContext();

        public int iMasach { set; get; }
        public string sTensach { set; get; }
        public string sAnhbia { set; get; }
        public Double dDongia { set; get; }
        public int iSoluong { set; get; }
        public Double dThanhtien
        {
            get { return iSoluong * dDongia; }
        }
        //Khởi tạo giỏ hàng theo Masach được truyền vào với Soluong mặc định là 1

        public Giohang(int Masach)
        {
            iMasach = Masach;
            SACH sach = db.SACHes.Single(n => n.Masach == iMasach);
            sTensach = sach.Tensach;
            sAnhbia = sach.Hinhminhhoa;
            dDongia = double.Parse(sach.Dongia.ToString());
            iSoluong = 1;
        }
    }
}