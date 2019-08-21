using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Giro : Account
    {
        public Giro(string Owner) : base(Owner)
        {

        }
        public Giro(string Owner, decimal Balance) : base(Owner, Balance)
        {

        }   
    }
}
