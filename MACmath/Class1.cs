using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACmathS
{
    public class MACmath
    {
        public bool InRnage(String ss,String ee,String ValueV)
        { 
          Int64 s,e,Value;
          s=  Int64.Parse(ss, System.Globalization.NumberStyles.HexNumber);
          e=  Int64.Parse(ee, System.Globalization.NumberStyles.HexNumber);
          Value = Int64.Parse(ValueV, System.Globalization.NumberStyles.HexNumber);
          return (Value >= s && Value <= e);
        }
    }
}
