using System.Data;
using ExcelDataReader;
using System.Text;

namespace MVPSt_2023_Feb_Competition.Utilities
{
    //[TestClass]
    [TestFixture]
    public class ExcelLib
    {
        public class Datacollection
        {
            public int rowNumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }
        }
        public static void ClearData()
        {
            dataCol.Clear();
        }

        public static DataTable ExcelIntoDataTable(string filePath, string sheetName)
        {
            // open file and return as stream
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)

                // added next line to allow newer formats to be recognized
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = reader.AsDataSet();
                    // get all tables
                    DataTableCollection alltables = result.Tables;
                    // store the data in a final DataTable
                    DataTable temporaryDataTable = alltables[sheetName];

                    // close the stream in case we need to open a new external file later
                    stream.Close();

                    return temporaryDataTable;
                }
            }
        }

        // place the data from the temporary internal data table into a collection
        static List<Datacollection> dataCol = new List<Datacollection>();

        public static void PopulateIntoCollection(string filePath, string sheetName)
        {
            ExcelLib.ClearData();
            DataTable tablereturnedfromExcel = ExcelIntoDataTable(filePath, sheetName);

            //Iterate through the rows and columns of the Table
            for (int row = 1; row <= tablereturnedfromExcel.Rows.Count; row++)
            {
                for (int col = 0; col < tablereturnedfromExcel.Columns.Count; col++)
                {
                    // dtTable is another temporary internal table used to build the final dataCol data collection table

                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        // always set colName to row 0's colValue -- even when row > 1
                        //colName = tablereturnedfromExcel.Columns[col].ColumnName,
                        colName = tablereturnedfromExcel.Rows[0][col].ToString(),
                        colValue = tablereturnedfromExcel.Rows[row - 1][col].ToString()
                        //colValue = tablereturnedfromExcel.Rows[row][col].ToString()
                    };

                    //Add all the details for each row to dataCol Datacollection
                    dataCol.Add(dtTable);
                }
            }
        }

        // read the data from the dataCol collection
        public static string ReadData(int rowNumberParm, string columnName)
        {
            //string data;
            try
            {
                //Retrieving Data using LINQ to reduce much of iterations

                //rowNumber = rowNumber - 1;
                //string data = (from colData in dataCol
                
                var data = (from colData in dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumberParm
                               select colData.colValue).SingleOrDefault();
                               //select colData.colValue).Single();

                return data.ToString();
                //return data;
            }

            catch (Exception e)
            {
                //Added by Kumar
                Console.WriteLine("Exception occurred in ExcelLib Class ReadData Method!" + Environment.NewLine + e.Message.ToString());
                return null;
            }
        }
    }
}