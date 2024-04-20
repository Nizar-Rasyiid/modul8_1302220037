using modul8_1302220037;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MOD8_1302223071
{

    class Program
    {
        static void Main(string[] args)
        {
            int trf, pilih;
            BankTransferConfig Conf = new BankTransferConfig();
            Console.WriteLine("Language / Bahasa :");
            Conf.bankConfig.lang = Console.ReadLine();
            if (Conf.bankConfig.lang == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer: ");
                trf = Convert.ToInt32(Console.ReadLine());


                if (trf < Conf.bankConfig.transfer.threshold)
                {
                    Console.WriteLine("Transfer Fee = " + Conf.bankConfig.transfer.low_fee);
                    Console.WriteLine("Total Amount = " + (trf + Conf.bankConfig.transfer.low_fee));
                    Console.WriteLine("Select Transfer Method : ");
                    for (int i = 0; i < Conf.bankConfig.methods.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " " + Conf.bankConfig.methods[i]);
                    }

                    pilih = Convert.ToInt32(Console.ReadLine());
                    if (pilih == 1)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.bankConfig.confirm.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                    else if (pilih == 2)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.bankConfig.confirm.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                    else if (pilih == 3)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.bankConfig.confirm.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                    else if (pilih == 4)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.bankConfig.confirm.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Transfer Fee = " + Conf.bankConfig.transfer.high_fee);
                    Console.WriteLine("Total Amount = " + (trf + Conf.bankConfig.transfer.high_fee));
                    Console.WriteLine("Select Transfer Method : ");
                    for (int i = 0; i < Conf.bankConfig.methods.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " " + Conf.bankConfig.methods[i]);
                    }
                    pilih = Convert.ToInt32(Console.ReadLine());
                    if (pilih == 1)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.bankConfig.confirm.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                    else if (pilih == 2)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.bankConfig.confirm.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                    else if (pilih == 3)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.bankConfig.confirm.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                    else if (pilih == 4)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.bankConfig.confirm.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                }

            }
            else if (Conf.bankConfig.lang == "id")
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");
                trf = Convert.ToInt32(Console.ReadLine());
                if (trf <= Conf.bankConfig.transfer.threshold)
                {
                    Console.WriteLine("Biaya Transfer = " + Conf.bankConfig.transfer.low_fee);
                    Console.WriteLine("Total Biaya = " + (trf + Conf.bankConfig.transfer.low_fee));
                    Console.WriteLine("Pilih Metode Transfer : ");
                    Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi : ");
                    string crf = Console.ReadLine();
                    if (crf == Conf.bankConfig.confirm.id)
                    {
                        Console.WriteLine("Proses Transfer Berhasil");
                    }
                    else
                    {
                        Console.WriteLine("Transfer dibatalkan");
                    }
                }
                else
                {
                    Console.WriteLine("Biaya Transfer = " + Conf.bankConfig.transfer.high_fee);
                    Console.WriteLine("Total Biaya = " + (trf + Conf.bankConfig.transfer.high_fee));
                    Console.WriteLine("Pilih Metode Transfer : ");
                    for (int i = 0; i < Conf.bankConfig.methods.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " " + Conf.bankConfig.methods[i]);
                    }
                    pilih = Convert.ToInt32(Console.ReadLine());
                    if (pilih == 1)
                    {
                        Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.bankConfig.confirm.id)
                        {
                            Console.WriteLine("Proses Transfer Berhasil");
                        }
                        else
                        {
                            Console.WriteLine("Transfer dibatalkan");
                        }
                    }
                    else if (pilih == 2)
                    {
                        Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.bankConfig.confirm.id)
                        {
                            Console.WriteLine("Proses Transfer Berhasil");
                        }
                        else
                        {
                            Console.WriteLine("Transfer dibatalkan");
                        }
                    }
                    else if (pilih == 3)
                    {
                        Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.bankConfig.confirm.id)
                        {
                            Console.WriteLine("Proses Transfer Berhasil");
                        }
                        else
                        {
                            Console.WriteLine("Transfer dibatalkan");
                        }
                    }
                    else if (pilih == 4)
                    {
                        Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.bankConfig.confirm.id)
                        {
                            Console.WriteLine("Proses Transfer Berhasil");
                        }
                        else
                        {
                            Console.WriteLine("Transfer dibatalkan");
                        }
                    }

                }
            }

        }
    }
}