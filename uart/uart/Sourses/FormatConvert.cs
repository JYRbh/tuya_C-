using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uart.Sourses
{
    public static class FormatConvert
    {
        public static string FiltHexString(string HexStr)
        {
            string NewHexStr = "";
            //检查参数合法性，忽略非法字符（如空格）
            foreach (char Hex in HexStr)
            {
                if (Uri.IsHexDigit(Hex))
                {
                    NewHexStr += Hex;
                }
            }
            return NewHexStr;
        }

        ///16进制字符串->字节数组（处理16进制字符串）
        public static byte[] HexStringToBytes(string HexStr)
        {
            //检查参数合法性，忽略非法字符（如空格）
            string NewHexStr = FiltHexString(HexStr);
            //高位补0
            if (NewHexStr.Length % 2 != 0)
            {
                NewHexStr = NewHexStr.PadLeft(NewHexStr.Length + 1, '0');
            }
            //转换
            byte[] Bytes = new byte[NewHexStr.Length / 2];
            for (int i = 0; i < NewHexStr.Length; i += 2)
            {
                Bytes[i / 2] = (byte)Convert.ToByte(NewHexStr.Substring(i, 2), 16);
            }

            return Bytes;
        }

        ///字节数组->16进制字符串（以16进制形式显示字节数组）
        public static string BytesToHexString(byte[] Bytes)
        {
            string HexString = BitConverter.ToString(Bytes);

            return HexString.Replace('-', ' ');
        }
        public static string BytesToHexString(byte[] Bytes, int startIndex, int length)
        {
            string HexString = BitConverter.ToString(Bytes,startIndex,length);

            return HexString.Replace('-', ' ');
        }

        ///文本字符串->字节数组->16进制字符串（以16进制形式显示字符串中的每个字符）
        public static string StringToHexString(string str)
        {
            byte[] Bytes = Encoding.UTF8.GetBytes(str);

            return BytesToHexString(Bytes);
        }

        ///16进制字符串->字节数组->文本字符串（以字符串形式显示）
        public static string HexStringToString(string str)
        {
            byte[] Bytes = HexStringToBytes(str);

            return Encoding.UTF8.GetString(Bytes);
        }
    }
}
