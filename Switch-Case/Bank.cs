using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    public class Bank
    {
        public BankBranchStatus Status{set; get;}
        
        public void PrintBankStatus(BankBranchStatus bankStatus)
        {
            if (bankStatus == BankBranchStatus.Open)
                Console.WriteLine("Bank is open now");
            else if (bankStatus == BankBranchStatus.Close)
                Console.WriteLine("Bank is closed");
            else if (bankStatus == BankBranchStatus.VIPCustomerOnly)
                Console.WriteLine("Bank is only open of VIPs");
            else
                Console.WriteLine("Invalid Inputs");
        }
    }

    public enum BankBranchStatus
    {
        Open,
        Close,
        VIPCustomerOnly
    }
}
