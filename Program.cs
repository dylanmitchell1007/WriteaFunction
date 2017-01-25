using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WriteAfunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp = "";
            Gene app = new Gene("11111111");
            foreach (char a in app.First)
            {
                tmp = Invert(a);
                Invert(a);
            }
           

        }
        static public char Invert(char s)
        {
            return ((s == '0') ? '1' : '0');
        }
        

        public class Gene
        {
            public Gene(string s)
            {
                if (s.Length != 8)
                    throw new Exception("too big or too small... must be 8 long");
                value = s;
                first = value.Substring(4);
                last = value.Remove(4, 4);
            }
            string value;
            string last;
            string first;
            public override string ToString()
            {
                return value;
            }
            public string First
            {
                get
                {
                    return first;
                }
            }

            public string Last
            {
                get
                {
                    return Last;
                }
            }
        }
    }
               
}



