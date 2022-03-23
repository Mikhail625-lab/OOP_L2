using System;
using _010_Task01;

namespace _000_EnterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtyAccounts = 5;
            Console.WriteLine("Run Task_01");
            //Console.ReadKey();
            BillBank[] arrayBills = new BillBank[qtyAccounts];


            /*
 * Переопределить конструктор по умолчанию, создать :
    1. [БАЛАНС]     конструктор для заполнения поля баланс, 
    2. [ТИП СЧЁТА]  конструктор для заполнения поля тип банковского счета, 
    3. [БАЛАНС + ТИП] конструктор для заполнения баланса и типа банковского счета. 
 */

            // generate accounts with construcor 1 [БАЛАНС]
            for (int i = 0; i < arrayBills.Length; i++)
            {
                arrayBills[i] = new BillBank(Convert.ToDouble(i * 100));
                arrayBills[i].InfoPrint();
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
    }
}
