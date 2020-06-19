using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Class1
{
	public Class1()
	{
        /// <summary>
        /// 16进制编码
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public byte[] strToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0) hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);
            return returnBytes;
        }
        public string ByteArrayToHexString(Byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2} ", b);
            return hex.ToString();
        }
        public string ByteArrayToDecString(Byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:D} ", b);
            return hex.ToString();
        }
    }
}
