using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_1302220037
{
    internal class BankTransferConfig
    {
        public Config bankConfig;
        public const string filePath = "D:\\KPL C#\\modul8_1302220037\\modul8_1302220037\\bin\\Debug\\net8.0\\bank_transfer_config.json";
        public BankTransferConfig()
        {
            try
            {
                ReadConfigFile();
            }catch(Exception ex)
            {
                setDefault();
                WriteNewConfigFile();
            }
        }
        public class Config
        {
            public string lang { get; set; }
            public Transfer transfer { get; set; }
            public List<string> methods { get; set; }
            public Confirm confirm { get; set; }
            public Config() { }

            public Config(string lang, Transfer transfer, List<string> methods, Confirm confirm)
            {
                this.lang = lang;
                this.transfer = transfer;
                this.methods = methods;
                this.confirm = confirm;
            }
        }

        public class Transfer
        {
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }
            public Transfer(int threshold, int low_fee, int high_fee)
            {
                this.threshold = threshold;
                this.low_fee = low_fee;
                this.high_fee = high_fee;
            }

        }

        public class Confirm { 
            public string en {  get; set; }
            public string id { get; set; }

            public Confirm (string en, string id)
            {
                this.en = en;
                this.id = id;
            }
        }

        public void setDefault()
        {
            Transfer tran = new Transfer(25000000, 6500, 15000);
            Confirm confrm = new Confirm("yes", "ya");

             this.bankConfig = new Config("en", tran,["RTO(real - time)", "SKN", "RTGS", "BI FAST"], confrm);
        }

        public Config ReadConfigFile()
        {
            string configJsonData = File.ReadAllText(filePath);
            bankConfig = JsonSerializer.Deserialize<Config>(configJsonData);
            return bankConfig;
        }

        public void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(this.bankConfig, options);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
