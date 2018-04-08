using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BCH_code
{
    class Coder
    {
        private int n;
        private int k;
        private int r;
        string poll;
        string input;
        int remainder;

        private Dictionary<int, BitArray> dic = new Dictionary<int, BitArray>();

        public Dictionary<int, BitArray> Dic
        {
            get
            {
                return dic;
            }
        }

        public Coder(int n, int k, string poll, string input)
        {
            this.n = n;
            this.k = k;
            this.poll = poll;
            this.input = input;
            this.r = n - k;
        }

        public void CreateInfoCombinations()
        {
            int[] arInput = Array.ConvertAll(input.Split(' '), elem => { return Convert.ToInt32(elem); });

            int pollDec = Convert.ToInt32(poll, 2);
            for (int i = 0; i < arInput.Length; i++)
            {
                int numOfComb = arInput[i] << r; //приписали r нулей к двоичной записи числа
                remainder = GetRemainder(numOfComb, pollDec);
                int allowedComb = numOfComb ^ remainder;

                string sAllowedComb = Convert.ToString(allowedComb, 2);
                while (sAllowedComb.Length < n) sAllowedComb = sAllowedComb.Insert(0, "0");
                BitArray bAllowedComb = new BitArray(sAllowedComb.Select(c => c == '1').ToArray());
                dic.Add(i, bAllowedComb);
            }
        }

        //Функция считает длину двоичного представлений числа a, 
        //результат возвращается в b
        public void Count(int a, ref int b)
        {
            b = 0;
            while ((a >> b) != 0) b++;
        }

        //Функция нахождения остатка от деления y на z по модулю два
        //y и z вводятся в виде десятичных чисел
        //остаток в виде десятичного числа возвращается в y
        public int GetRemainder(int y, int z)
        {
            int k = 1;
            Count(z, ref k);

            int diff = 0;
            do
            {
                int n = 1;
                Count(y, ref n);
                diff = n - k;
                if (diff < 0) break;
                int zz = z << diff;
                y = y ^ zz;
            }
            while (diff != 0);
            return y;
        }

        public string ToBitString(BitArray bits)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < bits.Count; i++)
            {
                char c = bits[i] ? '1' : '0';
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
