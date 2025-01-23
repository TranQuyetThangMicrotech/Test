using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._00_Custom
{
    public class CustomGridView
    {
        private static volatile CustomGridView _instance;

        static object key = new object();
        // Không cho contructor từ bên ngoài
        private CustomGridView() { }
        // Phải thông qua  1 instance
        public static CustomGridView Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (key)
                    {
                        if (_instance == null) // Double-Check Locking
                        {
                            _instance = new CustomGridView();
                        }
                        //_instance = new CustomGridView();
                    }
                }
                return _instance;
                //if (_instance != null)
                //{
                //    return _instance;
                //}
                //_instance = new CustomGridView();
                //return _instance;
            }

            //private set
            //{
            //    _instance = value;
            //}
        }

        public void CustomDrawIndicator(RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle < 0) // Group row
                {
                    int groupIndex = Math.Abs(e.RowHandle);
                    e.Info.DisplayText = $"[{groupIndex}]";
                }
                else if (e.RowHandle >= 0) // Data row
                {
                    int rowIndex = e.RowHandle + 1;
                    e.Info.DisplayText = rowIndex.ToString();
                }
                e.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            }
        }
    }
}
