using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_Experimenting
{
    public class encryption
    {
        private string dataToEncrypt;
        private string encryptedData;

        public encryption(string data, string enc)
        {
            dataToEncrypt = data;
            encryptedData = enc;
        }

        public encryption()
        {

        }

        public string rot13(string data)
        {
            dataToEncrypt = data;
            char[] array = dataToEncrypt.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }

            return new string(array);
        }

    }
}