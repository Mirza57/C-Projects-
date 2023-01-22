using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldNamespace;

namespace Management_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country countryOneInstance = new Country();
           // Country countryTwoInstance = new Country();

            CountryLanguages countryLanguages = new CountryLanguages();
            countryLanguages.FirstLanguage = Languages.English.ToString();
            countryLanguages.SecondLanguage = Languages.Dutch.ToString();

           // countryOneInstance.CountryLanguages= countryLanguages;

            countryOneInstance.PlanetName = "Earth";
            countryOneInstance.CountryName = "Pakistan";

            countryOneInstance.Currencies = Currencies.PKR;
            countryOneInstance.Continents = Continents.Asia;

            countryOneInstance.SayHi();
            countryOneInstance.SayHi(countryOneInstance.CountryName);

            Console.WriteLine($"Planet is {countryOneInstance.PlanetName} and country is {countryOneInstance.CountryName} and the currency whick will work there is {countryOneInstance.Currencies}");
            
            

        }
    }

}
