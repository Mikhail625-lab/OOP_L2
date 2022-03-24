using System;

namespace _010_Task01
{

    /// <summary>
    /// for run and test Task_001
    /// </summary>
    public class Task01
    {
        private int totalTotalQtyAccounts;
        public int TotalQtyAccounts { get; set; }

        public Task01() => TotalQtyAccounts = 12;
        public Task01(int qtyElements) => TotalQtyAccounts = qtyElements;

        public void Run()
        {
            string lineDivided = "________________________________\n"; 
            BillBank[] arrayBills = new BillBank[TotalQtyAccounts];
            

            // generate accounts with construcor 1 [БАЛАНС]
            Console.Write("\t   [БАЛАНС]            " + lineDivided);

            int j = 0;
            for (int i = 0; i < arrayBills.Length/3; i++, j++)
            {
                arrayBills[j] = new BillBank(Convert.ToDouble(i * 200) );
                arrayBills[j].InfoPrint();
            }

            // generate accounts with construcor 2 [ТИП СЧЁТА] 
            Console.Write("\t   [ТИП СЧЁТА]         " + lineDivided); 
            for (int i = 0; i < arrayBills.Length/3; i++, j++)
            {
                arrayBills[j] = new BillBank("Budget");
                arrayBills[j].InfoPrint();
            }


            Console.Write("\t   [БАЛАНС+ТИП СЧЁТА]  " + lineDivided); 
            // generate accounts with construcor 3 [БАЛАНС]+ [ТИП СЧЁТА] 
            for (int i = 0; i < arrayBills.Length/3; i++, j++)
            {
                arrayBills[j] = new BillBank(Convert.ToDouble(100 + i * 10), "Credit" );
                arrayBills[j].InfoPrint();
            }



            {
                Console.WriteLine("\n\t\t Now enroll money (500 BTC)"); Console.ReadKey();
                arrayBills[0].EnrollMoney(500); arrayBills[0].InfoPrint();

                Console.WriteLine("\n\t\t Now try windraw money ..(1000 BTC) "); Console.ReadKey();
                arrayBills[0].WithdrawMoney(1000); arrayBills[0].InfoPrint();

                Console.WriteLine("\n\t\t Now try windraw money ..(300 BTC) "); Console.ReadKey();
                arrayBills[0].WithdrawMoney(300); arrayBills[0].InfoPrint();

                Console.WriteLine("\n\t\t Bye! Have nice day!"); Console.ReadKey();
                Console.ReadKey();
            }

        }



    }// end_of_class

} // end_of__010_Task01
