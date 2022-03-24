using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Task01
{
    public class BillBank
    {

        private static ulong totalCount;
        public ulong TotalCount
        {
            get { return totalCount; }
            set
            {
                if (IsValidBankAccount(totalCount) == true) { totalCount = value; }
                else { Console.WriteLine("\t\tNumber bank account NOT valid!"); }
            }
        }


        //  ? may be readonly ? 
        private ulong bankAccount;
        public ulong BankAccount
        {
            get { return bankAccount; }
            set
            {
                if (IsValidBankAccount(bankAccount) == true) { bankAccount = value; }
                else { Console.WriteLine("\t\tNumber bank account NOT valid!"); }
            }
        }


        private double balance;
        public double Balance { get { return balance; } set { balance = value; } } // short record краткая запись геттера сеттера 


        private TypesBankAccount typeBA;
        public TypesBankAccount TypeBA 
        { get { return typeBA; } 
            set { typeBA = value; }
        } // TypesBankAccount type = TypesBankAccount.Contractor ;


        public void InfoPrint()
        {
            System.Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.Write("\t {0}: ", "Bank account");
            System.Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.Write("{0}", this.BankAccount);

            System.Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.Write("\t {0}: ", "type");
            System.Console.ForegroundColor = ConsoleColor.Gray;
            // System.Console.Write("{0}", Enum.GetName(typeof(typesBankAccount), typeBA));
            System.Console.Write("{0}", TypeBA);


            System.Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.Write("\t {0}: ", "balance");
            System.Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.Write("{0}", this.Balance);

            System.Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine();

        }

        /*
         * Переопределить конструктор по умолчанию, создать :
            1. [БАЛАНС]     конструктор для заполнения поля баланс, 
            2. [ТИП СЧЁТА]  конструктор для заполнения поля тип банковского счета, 
            3. [БАЛАНС + ТИП] конструктор для заполнения баланса и типа банковского счета. 
         */
        public BillBank() // constructor 0
        {
            GenerateBankAccount();

        }
        /// <summary>
        ///  constructor 1 [БАЛАНС] 
        /// </summary>
        /// <param name="summBalance"></param>
        public BillBank(double summBalance) //
        {
            this.GenerateBankAccount();
            this.Balance = summBalance;
        }

        /// <summary>
        /// constructor 2 [ТИП СЧЁТА]
        /// </summary>
        /// <param name="setTypes"></param>
        public BillBank(string nameType) //  
        {
            GenerateBankAccount();
            this.TypeBA = (TypesBankAccount)Enum.Parse(typeof(TypesBankAccount), nameType);
        }

        /// <summary>
        /// constructor 3  [БАЛАНС + ТИП СЧЁТА]
        /// </summary>
        /// <param name="summBalance"></param>
        /// <param name="setTypes"></param>
        public BillBank(double summBalance, string nameType )
        {
            this.GenerateBankAccount();
            this.Balance = summBalance;
            this.typeBA =(TypesBankAccount) Enum.Parse(typeof(TypesBankAccount), nameType);
        }


        /// <summary>
        ///     Создание номера счёта . Приращение\инкремент на 1
        /// </summary>
        void GenerateBankAccount() => bankAccount = ++TotalCount; //(expression-bodied method) метод сжатый до выражения (C#8.0 карманный саправочник Албахари стр.78)

        private bool IsValidBankAccount(ulong bankAccount)
        {
            // (Пока) заглушка. Здесь д.б. логика  проверки правильности банковского счёта 
            return true;
        }


        /// <summary>
        /// положить\зачислить на счёт :
        /// </summary>
        /// <param name="summ"></param>
        public void EnrollMoney(double summ) => this.Balance += summ;

        /// <summary>
        ///     снятие со счёта с проверко доступного остатка :
        /// </summary>
        /// <param name="summ"></param>
        public void WithdrawMoney(double summ)
        {
            if (this.Balance >= summ) { this.Balance -= summ; }
            else
            {
                Console.WriteLine("\t----------------------------------------");
                System.Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Error!! The amount exceeds the balance.\n\t\t Operation cannot be performed");
                System.Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("\t----------------------------------------");
        }


        // public void SetType(TypesBankAccount t, string s) => Enum.TryParse(s, out t);


    } // end of class BillBank


    /// <summary>
    ///     Коллекция существующих валют. Сделано для экпериментов. Не могу разобраться где (лучше) объявить
    /// </summary>
    public enum curensy
    {
        MGA, AFN, PAB, THB, VEF, BOB, ETB, VUV, KPW, KRW, UAH, PYG, ANG, HTG, GMD, MKD, DZD, BHD, JOD, IQD, KWD,
        LYD, RSD, TND, MAD, AED, STN, AUD, BSD, BBD, BZD, BMD, BND, XCD, GYD, HKD, ZWD, KYD, CAD, LRD, NAD, NZD,
        SGD, SBD, USD, SRD, TWD, TTD, FJD, JMD, VND, AMD, EUR, PLN, JPY, AOA, ZMK, MWK, GTQ, PGK, LAK, CRC, NIO,
        DKK, ISK, NOK, CZK, SEK, HRK, MMK, GEL, LVL, BGN, MDL, RON, ALL, HNL, SLL, SZL, TRY, LTL, LSL, AZN, TMТ,
        BAM, MZN, NGN, ERN, BTN, TOP, MOP, ARS, DOP, COP, CUP, MXN, UYU, PHP, CLP, BWP, BRL, IRR, YER, QAR, OMR,
        KHR, MYR, SAR, BYR, BYN, RUB, RUR, INR, IDR, MUR, NPR, PKR, SCR, LKR, MVR, ZAR, GHS, PEN, KGS, TJS, UZS,
        BDT, WST, KZT, MNT, MRO, AWG, HUF, BIF, GNF, DJF, KMF, CDF, RWF, CHF, XPF, XOF, XAF, GBP, GIP, EGP, LBP,
        SHP, SYP, SDG, FKP, ILS, KES, SOS, TZS, UGX, CVE, CNY
    }


    public enum TypesBankAccount : byte// тип(ы) счета (использовать перечислимый тип) 
    {
        Temporary,// временный 
        Currency, // валютный
        Current, // текущий
        Credit, // кредитный
        Budget,// бюджетный
        Card  // карточный
    }


} // end of namespace of _010_Task01


