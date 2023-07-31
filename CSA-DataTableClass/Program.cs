using System;
using System.Data;

namespace CSA_DataTableClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.WindowHeight = 30;

            Console.WriteLine("\n----- 시작 / Press Any Key -----\n");
            Console.ReadKey();

            //----------

            /** DataTable 생성 */
            DataTable gDataTable = new DataTable();

            /** Column 열 생성 & DataTable 추가 */
            DataColumn vDataColumn;

            vDataColumn = new DataColumn();
            vDataColumn.ColumnName = "Column-1st";
            gDataTable.Columns.Add(vDataColumn);

            vDataColumn = new DataColumn();
            vDataColumn.ColumnName = "Column-2nd";
            gDataTable.Columns.Add(vDataColumn);

            vDataColumn = new DataColumn();
            vDataColumn.ColumnName = "Column-3rd";
            gDataTable.Columns.Add(vDataColumn);


            /** Row 행 생성 & DataTable 추가 */
            DataRow vDataRow;

            vDataRow = gDataTable.NewRow();
            vDataRow[0] = "Val-11";
            vDataRow[1] = "Val-12";
            vDataRow[2] = "Val-13";
            gDataTable.Rows.Add(vDataRow);

            vDataRow = gDataTable.NewRow();
            vDataRow["Column-1st"] = "Val-21";
            vDataRow["Column-2nd"] = "Val-22";
            vDataRow["Column-3rd"] = "Val-23";
            gDataTable.Rows.Add(vDataRow);

            /** Row 행 생성 & DataTable 추가 */
            gDataTable.Rows.Add("Val-31", "Val-32", "Val-33");

            /** DataTable 값확인 - index */
            foreach (DataRow lpRow in gDataTable.Rows)
            {
                Console.WriteLine($"{lpRow[0]}, {lpRow[1]}, {lpRow[2]}");
            }

            Console.WriteLine();

            /** DataTable 값확인 - Column Name */
            foreach (DataRow lpRow in gDataTable.Rows)
            {
                Console.WriteLine($"{lpRow["Column-1st"]}, {lpRow["Column-2nd"]}, {lpRow["Column-3rd"]}");
            }

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
