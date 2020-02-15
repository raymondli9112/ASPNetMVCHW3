using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Li_Raymond_HW3.Models
{   
    public enum enumCustomerType
    {
        Walkup, 
        Catering
    }
    public abstract class Order
    {
        const Decimal TACO_PRICE = 3; //Fields (Named Constants) 
        const Decimal SANDWICH_PRICE = 5;
        public enumCustomerType CustomerType { get; set; }
        public Int32 NumberOfSandwiches { get; set; }
        public Int32 NumberOfTacos { get; set; }
        public Decimal SandwichSubtotal { get; set; }
        public Decimal Subtotal { get; set; }
        public Decimal TacoSubtotal { get; set; }
        public Decimal Total { get; set; }
        public Int32 TotalItems { get; set; }
        
        public virtual void CalcSubtotals()
        {
            TotalItems = NumberOfSandwiches + NumberOfTacos;
            SandwichSubtotal = NumberOfSandwiches * SANDWICH_PRICE;
            TacoSubtotal = NumberOfTacos * TACO_PRICE;
            Subtotal = SandwichSubtotal + TacoSubtotal;            
            return;
        }
    }
}
