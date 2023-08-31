using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Kociemba;

namespace MBLDTracker.DataAccess.Models
{
    public class ScrambleModel
    {
        public string Scramble { get; set; }
        public string ColorString { get; set; }
        public ScrambleModel()
        {
            Scrambler.GenerateRandomScramble(this);
        }
    }
}
