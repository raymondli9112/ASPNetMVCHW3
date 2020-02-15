using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Li_Raymond_HW3.Models
{
    public class CateringOrder: Order
    {
        public String CustomerCode { get; set; }
        public Decimal DeliveryFee { get; set; }
        public Boolean PreferredCustomer { get; set; }
        public void CalcSubtotals(Decimal decDeliveryFee)
        {
            base.CalcSubtotals();
            DeliveryFee = PreferredCustomer ? 0 : decDeliveryFee;
            base.Total = Subtotal + DeliveryFee;
            return;
        }
    }
}
