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
        private uint NumberOfFields = 37;

        private string seed;

        private int round = 0;

        public Wheel()
        {
            this.seed = getSeed();
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
            byte[] buffer = new byte[128 / 2];
            Random random = new Random();
            random.NextBytes(buffer);
            return String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
        }

        private static String getSHA256Hash(String value) //generate random string (hex)
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
