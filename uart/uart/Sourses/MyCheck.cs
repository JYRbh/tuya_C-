using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace uart.Sourses
{
    public static class MyCheck
    {

        public static ushort CrcCheck(byte[] buf, int count)
        {
            uint temp = 0;
            ushort crc;
            ushort msgIndex = 0;
            byte[] msg = buf;

            while (count-- != 0)
            {
                for (ushort i = 0x80; i != 0; i = (ushort)(i >> 1))
                {
                    temp <<= 1;
                    if ((temp & 0x10000) != 0)
                    {
                        temp = temp ^ 0x11021;
                    }
                    if ((msg[msgIndex] & i) != 0)
                    {
                        temp = temp ^ (0x10000 ^ 0x11021);
                    }
                }
                msgIndex++;
            }
            crc = (ushort)(temp);

            return (ushort)(crc & 0xFFFF);
        }
        public static ushort SumCheck(byte[] buf, int count)
        {
            uint sum = 0;
            byte[] msg = buf;

            for (int i = 0; i < count; i++)
            {
                sum += msg[i];
            }
            return (ushort)(sum & 0xFFFF);
        }


        /// <summary>
        /// Aes加密
        /// </summary>
        /// <param name="DecryptBytes">未加密字节数组</param>
        /// <param name="KeyBytes">密钥</param>
        /// <returns>加密字节数组</returns>
        public static byte[] AesEncrypt(byte[] DecryptBytes, byte[] KeyBytes)
        {
            Aes Aes = Aes.Create();
            Aes.Key = KeyBytes;
            Aes.Mode = CipherMode.ECB;
            Aes.Padding = PaddingMode.Zeros;
            return Aes.CreateEncryptor().TransformFinalBlock(DecryptBytes, 0, DecryptBytes.Length);
        }

        /// <summary>
        /// Aes解密
        /// </summary>
        /// <param name="EncryptBytes">加密字节数组</param>
        /// <param name="KeyBytes">密钥</param>
        /// <returns>解密字节数组</returns>
        public static byte[] AesDecrypt(byte[] EncryptBytes, byte[] KeyBytes)
        {
            Aes Aes = Aes.Create();
            Aes.Key = KeyBytes;
            Aes.Mode = CipherMode.ECB;
            Aes.Padding = PaddingMode.Zeros;
            return Aes.CreateDecryptor().TransformFinalBlock(EncryptBytes, 0, EncryptBytes.Length);
        }
    }
}
