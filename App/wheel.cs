using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette_App
{
    class FrenchWheel
    {
        int NumberOfFelds = 37;

        public void Test()
        {
            //string server_seed = "39b7d32fcb743c244c569a56d6de4dc27577d6277d6cf155bdcba6d05befcb34";
            //string lotto = "0422262831";
            //string round_id = "1";
            //SHA256 sha = SHA256.Create("39b7d32fcb743c244c569a56d6de4dc27577d6277d6cf155bdcba6d05befcb34-0422262831-1");
            string hash = sha256_hash("39b7d32fcb743c244c569a56d6de4dc27577d6277d6cf155bdcba6d05befcb34-0422262831-1");
            //string roll = hexdec(substr($hash, 0, 8)) % 15;
            MessageBox.Show(hash);
            //MessageBox.Show("Round $round_id = $roll");
        }

        private static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
