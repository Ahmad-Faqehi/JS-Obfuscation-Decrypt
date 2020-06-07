
using System;
using System.IO;
namespace MutiThreading

/**
*
* @author Ahmad Faqehi
* 
**/

{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Enter the size of Array: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            long[] erp = new long[x+1];

// Delete This Arrays and Write Yours.

erp[0] = 1466264675;
erp[1] = 1869440288;
erp[2] = 1953439853;
erp[3] = 2032161641;
erp[4] = 1952779530;
erp[5] = 1013461310;
erp[6] = 1500476704;
erp[7] = 1634886944;
erp[8] = 1952998688;
erp[9] = 1650815860;
erp[10] = 1009739825;
erp[11] = 1041041980;
erp[12] = 1651654157;
erp[13] = 171730994;
erp[14] = 1045719145;
erp[15] = 1931506789;
erp[16] = 2020876397;
erp[17] = 1970500640;
erp[18] = 1650794597;
erp[19] = 1852011129;
erp[20] = 1886676324;
erp[21] = 544108320;
erp[22] = 1869505824;
erp[23] = 1667329568;
erp[24] = 1701079412;
erp[25] = 555819068;
erp[26] = 795357758;
erp[27] = 0;

// End of Arrays

            String[] fina = new string[95];
            String output = "";

            for (int i = 1; i <= erp.Length; i++)
            {
                long thabet1 = 16777216;
                long thabet2 = 65536;
                long thabet3 = 256;
                long thabet4 = 1;
                long num = erp[i - 1];

                long result1 = num / thabet1;
                long step1 = num - result1 * thabet1;

                num = step1;

                long result2 = num / thabet2;
                long step2 = num - result2 * thabet2;

                num = step2;

                long result3 = num / thabet3;
                long step3 = num - result3 * thabet3;

                num = step3;

                long result4 = num / thabet4;
                long step4 = num - result4 * thabet4;


                output += (char)result1 + "" + (char)result2 + "" + (char)result3 + "" + (char)result4;


            }
            Console.Write(output);
            Console.WriteLine("");
        }

        

    }
}
