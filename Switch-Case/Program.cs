namespace Switch_Case
{
    public class Program
    {
        static void Main(string[] args)
        {
            var VIPCustomer = checkIfBankOpen(new Bank() { status = BankBranchStatus.VIPCustomerOnly}, true);
            Console.WriteLine(VIPCustomer);

            var notVIPCustomer = checkIfBankOpen(new Bank(){ status = BankBranchStatus.VIPCustomerOnly}, false);
            Console.WriteLine(notVIPCustomer);
        }

        // ORIGINAL SWITCH CASE STATEMENT
        /*
        static bool checkIfBankOpen(Bank bank, bool isVip)
        {
            bool result = false;
            switch (bank.status)
            {
                case BankBranchStatus.Open:
                    result = true;
                    break;
                case BankBranchStatus.Close:
                    result = false;
                    break;
                case BankBranchStatus.VIPCustomerOnly:
                    result = isVip;
                    break;
                default:
                    result = false;
                    break;
            }
            return result;
        }
        */

        // NEW SWITCH CASE STATEMENT
        static bool checkIfBankOpen(Bank bank, bool isVip)
        {
            var result = bank.status switch
            {
                BankBranchStatus.Open => true,
                BankBranchStatus.Close => false,
                BankBranchStatus.VIPCustomerOnly => isVip,
                _ => false

            };
            return result;
        }
    }
}


