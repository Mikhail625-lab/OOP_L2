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

        //  ? readonly ? 
        private  ulong bankAccount;
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

        private typesBankAccount typeBA;
        private enum typesBankAccount  // тип(ы) счета (использовать перечислимый тип) 
        {
            card, // карточный
            credit, // кредитный
            budget, // бюджетный
            current, // текущий
            currency, // валютный
            temporary // временный 
        }

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
            System.Console.Write("{0}", typeBA);


            System.Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.Write("\t {0}: ", "balance");
            System.Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.Write("{0}", this.Balance);

            System.Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine();

        }

        /*
         * Переопределить конструктор по умолчанию, создать :
            1. конструктор для заполнения поля баланс, 
            2. конструктор для заполнения поля тип банковского счета, 
            3. конструктор для заполнения баланса и типа банковского счета. 
         */
        public BillBank() // constructor 1
        {
            GenerateBankAccount();
            typesBankAccount typeBA = typesBankAccount.card;
        }

        public BillBank(double summBalance) // constructor 1
        {
            GenerateBankAccount();
            Balance = summBalance;
        }

        void GenerateBankAccount() => bankAccount = ++TotalCount; //(expression-bodied method) метод сжатый до выражения (C#8.0 карманный саправочник Албахари стр.78)

        private bool IsValidBankAccount(ulong bankAccount)
        {
            // (Пока) заглушка. Здесь д.б. логика  проверки правильности банковского счёта 
            return true;
        }


        // положить\зачислить :
        public void EnrollMoney(double summ) => this.Balance += summ;


        // снятие :
        public void WithdrawMoney(double summ)
        {
            if (this.Balance >= summ) { this.Balance -= summ; }
            else {
                System.Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("\t Error!! The amount exceeds the balance.\n\t\t Operation cannot be performed");
                System.Console.ForegroundColor = ConsoleColor.Gray;
            }

        }


    } // end of class BillBank

}
