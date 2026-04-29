using modul9_103022400137;
using System.ComponentModel.Design;
using System.Diagnostics;

public class program
{
    static void main(string[] args)
    {
        BankTransferConfig bank = new BankTransferConfig();

        if (bank.config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money transfer: ");
        }
        else if (bank.config.lang == "id")
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di transfer: ");
        }
    }
}





