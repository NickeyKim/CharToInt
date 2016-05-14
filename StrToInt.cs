using System;
using System.Text;

namespace StrToInt
{
	class MainClass
	{
		/* Start to the First Character '0'
		 * if First Character is '-'
		 * 	Sets Negative Flag
		 * 	Move to Next 
		 * for Each Char 
		 * 	multiply it x 10
		 * 	(NumChar - '0') + Number
		 * if Negative Flag
		 *  change it to Negative
		 * Return Num
		 */
		public static int StrToInt(string str){
			int i = 0; 
			int num = 0;
			int len = str.Length;
			bool neg = false;
				
			if (str [0] == '-') {
				neg = true;
				i = 1;
			}
			while (i < len) {
				num = num * 10;
				num = str [i] - '0' + num;      //Char - char'0' -> the char's Code
				i++;
			}
			if (neg == true) {
				num = -num;
			}

			return num;
		}

		public static readonly int Max_degit = 10;
		public static string intToStr ( int num){
			int i = 0;
			bool neg = false;
			char[] temp = new char[Max_degit + 1];

			if (num < 0) {
				num = -num;
				neg = true;
			}
			do {
				temp [i] = (char)((num % 10) + '0');
				num = num / 10;
				i++;
			} while( num != 0);
			StringBuilder str = new StringBuilder ();
			if (neg == true) {
				str.Append ('-');
			}
			while (i >=0) {
				str.Append (temp [i]);
				i--;
			}
			return str.ToString();
				
		}
		/* if Num is Negative
		 * 	multiply -1
		 *	bool Neg -> True
		 * while(Num !=0)
		 * 	Num % 10 + '0'-> Stores to Temp Buffer
		 *  Num / 10
		 * if Negative
		 *  Add '-'
		 * return string in reverse-order
		 * 	327/10 = 32 + 7
				32/10 = 3 + 2
				  3/10 = 0 + 3
		*/
		public static void Main (string[] args)
		{
			Console.WriteLine (StrToInt ("-327")*0 +"->if 0, it's integer");
			Console.WriteLine (intToStr (-12312412)+" is "+ intToStr(-12312412).GetType());
			Console.WriteLine ("Hello World!");
		}
	}
}
