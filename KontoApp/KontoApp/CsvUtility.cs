using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoApp
{
    public static class CsvUtility
    {
        public static void ToCSV(this DataTable dt, string filePath)
        {
            StreamWriter sw = new StreamWriter(filePath, false);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                sw.Write(dt.Columns[i]);
                if (i < dt.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            // für jede zeile
            foreach(DataRow dr in dt.Rows)
            {
                for(int i= 0; i< dt.Columns.Count; i++)
                {
                    if(!Convert.IsDBNull(dr[i]))
                    {
                        string wert = dr[i].ToString();
                        if(wert.Contains(','))
                        {
                            wert = String.Format("\"{0}\"", wert);
                            sw.Write(wert);
                        } else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if(i<dt.Columns.Count -1)
                    {
                        sw.Write(',');
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
}
