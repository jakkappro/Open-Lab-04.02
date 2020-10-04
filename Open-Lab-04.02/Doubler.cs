using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string ret = "";
            foreach(char ch in original)
            {
                ret += ch.ToString() + ch.ToString();
            }
            return ret;
        }
    }
}
