using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MongoClientTool
{
    public static class Utilities
    {
        static readonly string[] formatsextra = { 
             // Basic formats
            "yyyyMMddTHHmmsszzz",
            "yyyyMMddTHHmmsszz",
            "yyyyMMddTHHmmssZ",
            // Extended formats
            "yyyy-MM-ddTHH:mm:sszzz",
            "yyyy-MM-ddTHH:mm:sszz",
            "yyyy-MM-ddTHH:mm:ssZ",
            // All of the above with reduced accuracy
            "yyyyMMddTHHmmzzz",
            "yyyyMMddTHHmmzz",
            "yyyyMMddTHHmmZ",
            "yyyy-MM-ddTHH:mmzzz",
            "yyyy-MM-ddTHH:mmzz",
            "yyyy-MM-ddTHH:mmZ",
            // Accuracy reduced to hours
            "yyyyMMddTHHzzz",
            "yyyyMMddTHHzz",
            "yyyyMMddTHHZ",
            "yyyy-MM-ddTHHzzz",
            "yyyy-MM-ddTHHzz",
            "yyyy-MM-ddTHHZ",
            @"yyyy-MM-dd\THH:mm:ss\Z",
            @"yyyy-MM-dd\THH:mm:sss\Z",
             @"yyyy-MM-dd\THH:mm:ss.ff\Z",
             @"yyyy-MM-dd\THH:mm:ss.fff\Z",
             @"yyyy-MM-dd\THH:mm:sss.ff\Z",
             @"yyyy-MM-dd\THH:mm:sss.fff\Z"
            };

        static readonly string[] formats = { @"yyyy-MM-dd\THH:mm:ss.ff\Z",
                                             @"yyyy-MM-dd\THH:mm:ss.fff\Z",
                                             @"yyyy-MM-dd\THH:mm:sss.ff\Z",
                                             @"yyyy-MM-dd\THH:mm:sss.fff\Z"};

        public static DataTable FillDataTable(IEnumerable<BsonDocument> lstDoc)
        {
            DataTable dt = new DataTable();
            string parent = string.Empty;
            string x;
            foreach (BsonDocument obj in lstDoc)
            {
                DataRow dr = dt.NewRow();

                foreach (string key in obj.Names)
                {
                    object value = obj[key];
                    if (key.Contains("Date") || key.Contains("CreatedOn") || key.Contains("ModifiedOn"))
                    {
                        DateTime d;
                        DateTime.TryParseExact(
                            value.ToString(),
                            formatsextra,
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.AssumeUniversal, out d);
                        value = d.ToString();
                    }
                    //else
                    // x = value.ToString();
                    string colName = string.IsNullOrEmpty(parent) ? key : parent + "." + key;
                    if (!dt.Columns.Contains(colName))
                        dt.Columns.Add(colName);
                    dr[colName] = value;
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }

        public static DataTable FillDataTable<T>(IEnumerable<T> list)
        {
            Type type = typeof(T);
            var properties = type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
            //var prop;
            // var test3 = typeof(T).GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);


            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in properties)
            {

                if (info.PropertyType == typeof(List<StockData>))
                {
                    dataTable.Columns.Add(new DataColumn(info.Name, typeof(string)));
                }
                else if (info.PropertyType == typeof(StrategyInfo))
                {
                    Type subT = typeof(StrategyInfo);
                    var prop = subT.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
                    foreach (PropertyInfo inf in prop)
                    {
                        dataTable.Columns.Add(new DataColumn(inf.Name, Nullable.GetUnderlyingType(inf.PropertyType) ?? inf.PropertyType));
                    }
                }
                else if (info.Name!="StrategyId")
                {
                    dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
                }
                else
                {
                    dataTable.Columns.Add(new DataColumn("Identifier", Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
                }
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length-1];
                object[] vals=null;
                for (int i = 0; i < properties.Length; i++)
                {
                     if (properties[i].PropertyType == typeof(List<StockData>))
                    {
                        values[i] = JsonConvert.SerializeObject(properties[i].GetValue(entity));
                    }
                    else if (properties[i].PropertyType == typeof(StrategyInfo))
                    {
                        //values[i] = JsonConvert.SerializeObject(properties[i].GetValue(entity));
                        Type subT = typeof(StrategyInfo);
                        var prop = subT.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
                        vals = new object[prop.Length];
                        for (int j = 0; j < prop.Length; j++)
                        {
                            vals[j] = prop[j].GetValue(properties[i].GetValue(entity));
                        }
                        
                    }
                    else if (properties[i].PropertyType == typeof(DateTime))
                    {
                        DateTime d;
                        //DateTime.TryParseExact(
                        //    properties[i].GetValue(entity).ToString(),
                        //    formatsextra,
                        //    CultureInfo.InvariantCulture,
                        //    DateTimeStyles.AssumeUniversal, out d);
                        d = DateTime.Parse(properties[i].GetValue(entity).ToString());
                        values[i] = d.Date;
                    
                    }
                    else
                    {
                        values[i] = properties[i].GetValue(entity);
                    }
                }
                object[] z = new object[values.Length + vals.Length];
                values.CopyTo(z, 0);
                vals.CopyTo(z, values.Length);

                dataTable.Rows.Add(z);
               
            }

            return dataTable;
        }

        public static void ExportToExcel(this DataTable tbl, string excelFilePath = null)
        {
            try
            {
                if (tbl == null || tbl.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Workbooks.Add();

                // single worksheet
                Microsoft.Office.Interop.Excel._Worksheet workSheet = excelApp.ActiveSheet;

                // column headings
                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = tbl.Columns[i].ColumnName;
                }

                // rows
                for (var i = 0; i < tbl.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < tbl.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = tbl.Rows[i][j];
                    }
                }

                // check file path
                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        workSheet.SaveAs(excelFilePath);
                        excelApp.Quit();
                        //MessageBox.Show("Excel file saved!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }




    }
}
