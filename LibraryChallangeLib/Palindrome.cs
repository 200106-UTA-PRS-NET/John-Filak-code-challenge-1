using System;
using System.Text.RegularExpressions;


namespace LibraryChallangeLib
{
    public class Palindrome 
    {
        public bool isPalidrome(string a)
        {

            //Regex rx = new Regex("[^A-Za-z0-9 _]");
            string b = a.Replace(" ",  "");
            string c = b.Replace(".", "");
            string d = c.Replace(",", "");
            string e = d.ToLower();
            Char[] final = e.ToCharArray();

            for (int i = 0; i<final.Length; i++)
            { int end = (final.Length - (i + 1));
                char a1 = final[i];
                char a2 = final[end];

                if ( (a1.Equals(a2)) == false)
                {
                    break;
                }
                if(i == end)
                {
                    return true; 
                }
            }


            return false;
        }
        
    }
}
