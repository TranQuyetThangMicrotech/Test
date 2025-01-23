using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._03_Chamcong
{
    public class BangChamCongChiTiet
    {
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        public List<TB_KCCT> GetList(int id)
        {
            return db.TB_KCCT.Where(x => x.IDNV == id).ToList();
        }

        public void PhatSinhKyCongChiTiet(int idcty, int thang, int nam)
        {
            var lstnv = db.TB_NHANVIEN.ToList();
            if (lstnv.Count == 0) return;

            foreach (var item in lstnv)
            {
                List<string> listday = new List<string>();
                for (int j = 0; j <= GetDayNumber(thang, nam); j++)
                {
                    DateTime newdate = new DateTime(nam, thang, j);

                    switch (newdate.DayOfWeek.ToString())
                    {
                        case "Sunday":
                            listday.Add("CN");
                            break;

                        case "Saturday":
                            listday.Add("T7");
                            break;

                        default:
                            listday.Add("X");
                            break;
                    }
                }

                switch (listday.Count)
                {
                    case 28:
                        listday.Add("");
                        listday.Add("");
                        listday.Add("");
                        break;

                    case 29:
                        listday.Add("");
                        listday.Add("");

                        break;

                    case 30:
                        listday.Add("");

                        break;
                }

                TB_KCCT kc = new TB_KCCT();
                kc.IDNV = item.IDNV;

                kc.D1 = listday[0];
                kc.D2 = listday[0];
                kc.D3 = listday[0];
                kc.D4 = listday[0];
                kc.D5 = listday[0];
                kc.D6 = listday[0];
                kc.D7 = listday[0];
                kc.D8 = listday[0];
                kc.D9 = listday[0];
                kc.D10 = listday[0];
                kc.D11 = listday[0];
                kc.D12 = listday[0];
                kc.D13 = listday[0];
                kc.D14 = listday[0];
                kc.D15 = listday[0];
                //kc.D16 = listday[0];
                kc.D17 = listday[0];
                kc.D18 = listday[0];
                kc.D19 = listday[0];
                kc.D20 = listday[0];
                kc.D21 = listday[0];
                kc.D22 = listday[0];
                kc.D23 = listday[0];
                kc.D24 = listday[0];
                kc.D25 = listday[0];
                kc.D26 = listday[0];
                kc.D27 = listday[0];
                kc.D28 = listday[0];
                kc.D29 = listday[0];
                kc.D30 = listday[0];
                kc.D31 = listday[0];
            }
        }

        private int GetDayNumber(int thang, int nam)
        {
            int daynumber = 0;
            switch (thang)
            {
                case 2:
                    daynumber = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    daynumber = 30;
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daynumber = 31;
                    break;
            }
            return daynumber;
        }
    }
}