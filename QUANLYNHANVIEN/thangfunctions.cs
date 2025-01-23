using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHANVIEN
{
    public class thangfunctions
    {
        public static int demsongaylamviectrongthang(int thang, int nam)
        {
            int dem = 0;
            DateTime f = new DateTime(nam, thang, 01);
            //int x = f.Month + 1;
            while (f.Month == thang) 
            {
                if(f.DayOfWeek != DayOfWeek.Sunday)
                {
                    dem = dem + 1;
                }
                f = f.AddDays(1);
            }
            return dem;
        }

      

        public static int laysongaycuathang(int thang, int nam)
        {
            return DateTime.DaysInMonth(nam, thang);
        }
    }
}
