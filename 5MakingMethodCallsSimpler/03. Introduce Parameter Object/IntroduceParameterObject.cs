using System;
using System.Collections.Generic;
using System.IO;

namespace MakingMethodCallsSimpler
{
    public class IntroduceParameterObject
    {
        public IntroduceParameterObject(string name, string homeAddress, string country, string email, string telephone, string fileLocation)
        {
            SaveHomeAddress(name, homeAddress, email, country, fileLocation, telephone);
        }

        public void SaveHomeAddress(string name, string homeAddress, string country, string email, string fileLocation, string telephone)
        {

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(homeAddress)
                || string.IsNullOrEmpty(fileLocation) || string.IsNullOrEmpty(telephone))
            {
                Console.WriteLine("Input parameters are empty");
            }
            else
            {
                using FileStream fileStream = new FileStream(fileLocation, FileMode.Append);
                using StreamWriter writer = new StreamWriter(fileStream);
                List<string> aPersonRecod = new List<string>
                {
                    name,
                    homeAddress,
                    country,
                    email,
                    telephone
                };
                writer.WriteLine(aPersonRecod);
            }
        }
    }
}
