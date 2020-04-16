using Amazon; //after adding reference

namespace AccessModifiers_Ex
{
    class Program
    {
        public class GoldCustomer  : Customer
        {
            public void OfferVoucher()
            {
                // var rate = this.CheckAccess();    (this stmnt gives an error after deleting Checkaccess method)

                /*here CheckACcess mathod can be used since it is protected.
                 * But we Cannot access CalculateRating method since it is private.
                 * Also, if now I chnge anything in this protected method then it wwill affect the derived class,
                 * since changes must have to be done here itself.
                 * For eg now I remove the checkAccess method so it will give error in this method.*/
            }
        }
        static void Main(string[] args)
        {
            var customer = new Customer();

            // var customer_1 = new Customer_1(); this gives error since the class is in another assembly (i.e internal modifier)
            // but we can add reference and then it will work :

            var customer_1 = new Customer_1();

            Amazon.RateCalculator calculator = new RateCalculator();
            customer_1.Promote1();

        }
    }
}
