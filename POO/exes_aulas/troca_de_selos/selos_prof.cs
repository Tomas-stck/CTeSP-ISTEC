using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selos1
{
    //private protected internal public
    public class Utilidades
    {
        public String selosI(int q)
        {
            int quoc, r, s3, s5;
            string rslt = "";
            if (q >= 8) {
                r = q % 5;
                quoc = q / 5;
                switch (r)
                {
                    case 0:
                        s5 = quoc;
                        s3 = 0;
                        break;
                    case 1:
                        s5 = quoc-1;
                        s3 = 2;
                        break;
                    case 2:
                        s5 = quoc-2;
                        s3 = 4;
                        break;
                    case 3:
                        s5 = quoc;
                        s3 = 1;
                        break;
                    case 4:
                        s5 = quoc-1;
                        s3 = 3;
                        break;
                    default:
                        s3 = 0;s5 = 0;
                        break;
                }//switch
                rslt = "Selos cinco euros:" + s5.ToString() + "    Selos três euros:" + s3.ToString();
            } else {
                rslt = "Erro - retire a quantia";
            }//fim if..else

            return rslt;
        }//fim selos
    }
}




