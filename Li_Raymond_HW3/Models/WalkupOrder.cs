using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Li_Raymond_HW3.Models
{
    public class WalkupOrder: Order 
    {
        const Decimal SALES_TAX_RATE = 0.085M;
        public String CustomerName { get; set; }
        public Decimal SalesTax { get; set; }
        public override void CalcSubtotals()
        {
            base.CalcSubtotals();
            SalesTax = base.Subtotal * SALES_TAX_RATE;
            base.Total = SalesTax + base.Subtotal;
        }
    }
}
