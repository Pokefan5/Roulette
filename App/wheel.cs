using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette_App
{
    class Wheel
    {
        uint NumberOfFields = 37;

        string seed;

        int round = 0;

        private static Random random = new Random();

        public void Test()
        {
            //string server_seed = "39b7d32fcb743c244c569a56d6de4dc27577d6277d6cf155bdcba6d05befcb34";
            //string lotto = "0422262831";
            //string round_id = "1";
            //SHA256 sha = SHA256.Create("39b7d32fcb743c244c569a56d6de4dc27577d6277d6cf155bdcba6d05befcb34-0422262831-1");
            //string hash = getSHA256Hash("--");
            //string hashPart = hash.Substring(0, 8);
            //string roll = hexdec(substr($hash, 0, 8)) % 15;
            MessageBox.Show(Play().ToString());
            //MessageBox.Show("Round $round_id = $roll");
        }

        public Wheel()
        {
            this.seed = getSeed();
            MessageBox.Show(this.seed);
        }

        public uint Play()
        {
            // get round Hash
            string hash = getSHA256Hash(this.seed + "-" + this.round);

            // rise round counter
            this.round++;

            // get the first byte
            string hex = hash.Substring(0, 8);

            return Convert.ToUInt32(hex, 16) % NumberOfFields;
        }

        private string getSeed()
        {
            return GetRandomHexNumber(128);
        }

        private static string GetRandomHexNumber(int digits)
        {
            byte[] buffer = new byte[digits / 2];
            random.NextBytes(buffer);
            string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
            if (digits % 2 == 0)
                return result;
            return result + random.Next(16).ToString("X");
        }

        private static String getSHA256Hash(String value)
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
