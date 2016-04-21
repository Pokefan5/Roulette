using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Roulette_App
{
    /// <summary>
    /// Roulette table wheel
    /// </summary>
    class Wheel
    {
        /// <summary>
        /// The count of fields of a roulette table
        /// </summary>
        private uint NumberOfFields = 37;

        /// <summary>
        /// A random generating string for replying
        /// </summary>
        private string seed;

        /// <summary>
        /// The index of the current round
        /// </summary>
        private int round = 0;

        /// <summary>
        /// Initializise components
        /// </summary>
        public Wheel()
        {
            byte[] buffer = new byte[128 / 2];
            Random random = new Random();
            random.NextBytes(buffer);
            this.seed = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
        }

        /// <summary>
        /// Play a round
        /// </summary>
        /// <returns>The played number</returns>
        public uint Play()
        {
            // get round Hash
            string hash = computeHash(this.seed + "-" + this.round);

            // increase round counter
            this.round++;

            // get the first byte
            string hex = hash.Substring(0, 8);

            return Convert.ToUInt32(hex, 16) % NumberOfFields;
        }

        /// <summary>
        /// Generate a SHA256 hash
        /// </summary>
        /// <param name="value">The round string</param>
        /// <returns>The round hex</returns>
        private static String computeHash(String value)
        {
            StringBuilder Sb = new StringBuilder();
            SHA256 hash = SHA256.Create();

            // compute hash
            Byte[] result = hash.ComputeHash(Encoding.UTF8.GetBytes(value));

            // convert hash to HEX string
            foreach (Byte b in result)
                Sb.Append(b.ToString("x2")); // "x2" for 2 HEX Characters, e.g. 11110000 = F0
        
            return Sb.ToString();
        }
    }
}
