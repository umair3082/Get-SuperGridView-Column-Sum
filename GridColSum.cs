 using DevComponents.DotNetBar.SuperGrid;
 public decimal GridColSum(SuperGridControl gridname, int colnumber)
        {
            decimal Total = 0;

            foreach (GridRow row in gridname.PrimaryGrid.Rows)
            {
                Total += Convert.ToDecimal(row[colnumber].Value);
            }
            return Total;
        }
