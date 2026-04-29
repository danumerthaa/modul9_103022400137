using System.Text.Json;

using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace modul9_103022400137
{
    public class BankTransferConfig
    {
        public Config config;
        private const string filepath = @"bank_transfer_config.json";

        public BankTransferConfig() {
            try
            {
                ReadConfigFile();
            }
            catch {
                setDefault();
                WriteConfigFile();
            }
        }
        public void ReadConfigFile() {
            string Hasil = File.ReadAllText(filepath);
            config = JsonSerializer.Deserialize<Config>(Hasil);
        }
        public void WriteConfigFile() {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true

            };
            string tulisan = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filepath, tulisan);
        }
        public void setDefault ()
        {
            config = new Config();
            config.lang = "en";
            Transfer transfer = new Transfer(25000000, 6500, 15000);
            config.transfer = transfer;
            List<string> isi = new List<string>();
            isi.Add("RTO (real-time)");
            isi.Add("SKN");
            isi.Add("RTGS");
            isi.Add("BI FAST");
            config.methods = isi;
            Confirmation confirmation = new Confirmation();
            confirmation.en = "Yes";
            confirmation.id = "Ya";
            config.confirmation = confirmation;
        }
    }   
}
