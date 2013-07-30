using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace BL
{
    public class StaticClass
    {
        public static string UserName;
        public static string GroupUser;
        public static string UserID;
        public static string Authorization;
        public static bool StatusUser;
        public static string tenbenhvien;
        public static string matkhaumacdinh = "123";
        public static string donvithungan;
        public static string banthungan;
        public static string tenbanthungan;
        public static bool? Online;
        public static bool? OpenBigScreen = false;
        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

    }
}