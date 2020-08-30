using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ExcelLibrary.SpreadSheet;
using ifes.lib.domain.Catalogs;
using NPOI.HSSF.UserModel;

namespace ifes.Controllers.Helpers
{
    public class SpreadsheetHelper
    {
        public static HSSFWorkbook GenerateSpreadSheet(IList<Order> orders)
        {
            // create Excel spreadsheet file
            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet();
            var rowIndex = 0;
            // add column names
            var columnRow = sheet.CreateRow(rowIndex);
            columnRow.CreateCell(0).SetCellValue("Time");
            columnRow.CreateCell(1).SetCellValue("Catalog item");
            columnRow.CreateCell(2).SetCellValue("Amount");
            columnRow.CreateCell(3).SetCellValue("Price");
            columnRow.CreateCell(4).SetCellValue("Discount");
            rowIndex++;
            // add order values
            foreach (var order in orders)
            {
                var orderRow = sheet.CreateRow(rowIndex);
                orderRow.CreateCell(0).SetCellValue(order.Created);
                orderRow.CreateCell(1).SetCellValue(order.Item.Name);
                orderRow.CreateCell(2).SetCellValue(order.Amount);
                orderRow.CreateCell(3).SetCellValue(order.Item.Price);
                orderRow.CreateCell(4).SetCellValue(order.Item.Discount);
                rowIndex++;
            }
            // add total
            var totalRow = sheet.CreateRow(rowIndex);
            totalRow.CreateCell(3).SetCellValue("Total");
            totalRow.CreateCell(4).SetCellValue(getTotalSum(orders));

            return workbook;
        }

        private static double getTotalSum(IList<Order> orders)
        {
            double sum = 0.0;
            foreach (var order in orders)
            {
                sum += order.Amount * (order.Item.Price - order.Item.Discount);
            }
            return sum;
        } 
        
    }
}