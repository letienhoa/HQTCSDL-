using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;


namespace PhamMemQuanLyKho1._1.MyClassCode
{
    class KhoHang
    {

        public System.Data.Linq.Table<kho> LayKhoHang()
        {
            DataSet ds = new DataSet();
            DataClassDataContext QLK = new DataClassDataContext();
            return QLK.khos;
        }
        public List<LayThongTinKhoHang> LayThongTinChoKhoHang()
        {
            DataSet list = new DataSet();
            DataClassDataContext QLK = new DataClassDataContext();
            var ls2 =
                from a in QLK.khos
                join c in QLK.hanghoas
                on a.makho equals c.makho
                select new LayThongTinKhoHang()
                {
                    MaKho = a.makho,
                    TenKho = a.tenkho,

                };
            List<LayThongTinKhoHang> lstt = new List<LayThongTinKhoHang>();
            foreach (LayThongTinKhoHang item in ls2)
            {
                lstt.Add(item);
            }
            return lstt;

        }
        public bool ThemKho(string MaKho, string TenKho, ref string err)
        {

            DataClassDataContext QLK = new DataClassDataContext();
            kho k = new kho();
            k.makho= MaKho;
            k.tenkho = TenKho;

            QLK.khos.InsertOnSubmit(k);
            QLK.khos.Context.SubmitChanges();
            return true;

        }
        public bool XoaKho(ref string err, string MaKho)
        {
            DataClassDataContext QLK = new DataClassDataContext(); var bpQuery = from k in QLK.khos
                                                                                  where k.makho == MaKho
                                                                                  select k;
        QLK.khos.DeleteAllOnSubmit(bpQuery);
            QLK.SubmitChanges();
            return true;
        }
    public bool CapNhatKho(string MaKho, string TenKho, ref string err)
    {
        DataClassDataContext QLK = new DataClassDataContext();
        var bpQuery = (from bp in QLK.khos
                       where bp.makho == MaKho
                       select bp).SingleOrDefault();
        if (bpQuery != null)
        {
            bpQuery.tenkho = TenKho;
            QLK.SubmitChanges();
        }
        return true;
    }
}
}
