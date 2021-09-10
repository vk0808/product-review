using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReview
{
    class ProductDataTable
    {
        public DataTable AddToDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID", typeof(int));
            table.Columns.Add("UserID", typeof(int));
            table.Columns.Add("Rating", typeof(int));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("isLike", typeof(bool));

            table.Rows.Add(2, 3, 2, "Not Good", false);
            table.Rows.Add(3, 3, 1, "Bad", false);
            table.Rows.Add(1, 2, 4, "Good", true);
            table.Rows.Add(2, 2, 5, "Nice", true);
            table.Rows.Add(3, 2, 5, "Very Nice", true);
            table.Rows.Add(1, 1, 3, "Good", true);
            table.Rows.Add(2, 1, 4, "Good", true);
            table.Rows.Add(3, 1, 2, "Bad", true);
            table.Rows.Add(4, 5, 6, "Good", true);
            table.Rows.Add(1, 6, 3, "Not Good", true);
            table.Rows.Add(2, 7, 4, "Good", true);
            table.Rows.Add(3, 8, 2, "Bad", true);
            table.Rows.Add(4, 9, 6, "Nice", true);
            table.Rows.Add(1, 10, 3, "Good", true);
            return table;
        }
    }
}
