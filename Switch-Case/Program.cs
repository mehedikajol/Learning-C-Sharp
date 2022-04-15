namespace Switch_Case
{
    public class Program
    {
        static void Main(string[] args)
        {
            var VIPCustomer = checkIfBankOpen(new Bank() { Status = BankBranchStatus.VIPCustomerOnly }, true);
            Console.WriteLine(VIPCustomer);

            var notVIPCustomer = checkIfBankOpen(new Bank() { Status = BankBranchStatus.VIPCustomerOnly }, false);
            Console.WriteLine(notVIPCustomer);
        }

        // ORIGINAL SWITCH-CASE STATEMENT
        /*
        static bool checkIfBankOpen(Bank bank, bool isVip)
        {
            bool result = false;
            switch (bank.Status)
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

        // NEW SWITCH-CASE STATEMENT
        /*
        static bool checkIfBankOpen(Bank bank, bool isVip)
        {
            var result = bank.Status switch
            {
                BankBranchStatus.Open => true,
                BankBranchStatus.Close => false,
                BankBranchStatus.VIPCustomerOnly => isVip,
                _ => false

            };
            return result;
        }*/

        // NEW SWITCH-CASE STATEMENT {DIRECT RETURN}
        /*
        static bool checkIfBankOpen(Bank bank, bool isVip)
        {
            return bank.Status switch
            {
                BankBranchStatus.Open => true,
                BankBranchStatus.Close => false,
                BankBranchStatus.VIPCustomerOnly => isVip,
                _ => false

            };
        }*/

        // NEW SWITCH-CASE STATEMENT WITH LAMBDA METHOD
        /*
        static bool checkIfBankOpen(Bank bank, bool isVip) => 
            bank.Status switch
            {
                BankBranchStatus.Open => true,
                BankBranchStatus.Close => false,
                BankBranchStatus.VIPCustomerOnly => isVip,
                _ => false
            };
        */

        // SWITCH-CASE WITH SOME CHECKINGs
        /*
        static bool checkIfBankOpen(Bank bank, bool isVip)
        {
            return bank.Status switch
            {
                BankBranchStatus.Open => true,
                BankBranchStatus.Close => false,
                BankBranchStatus.VIPCustomerOnly when isVip => true,
                BankBranchStatus.VIPCustomerOnly when !isVip => false,
                _ => false
            };
        }
        */

        // SWITCH-CASE WITH TUPPLE CHECKING
        /*
        static bool checkIfBankOpen(Bank bank, bool isVip)
        {
            return (bank.status, isVip) switch
            {
                ( BankBranchStatus.Open, _ ) => true,
                ( BankBranchStatus.Close, _) => false,
                ( BankBranchStatus.VIPCustomerOnly, true ) => true,
                ( BankBranchStatus.VIPCustomerOnly, false) => false,
                (_, _) => false
            };
        }
        */

        // SWITCH-CASE WITH OBJECT LIKE BEHAVIOURS
        static bool checkIfBankOpen(Bank bank, bool isVip)
        {
            return bank switch
            {
                { Status: BankBranchStatus.Open} => true,
                { Status: BankBranchStatus.Close} => false,
                { Status: BankBranchStatus.VIPCustomerOnly} => isVip,
                { Status: _ } => false      
            };   
        }
    }
}


