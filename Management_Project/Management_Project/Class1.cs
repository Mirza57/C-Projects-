﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldNamespace
{
    abstract class World
    {
        private string planetName;
        private Continents continents;

        public string PlanetName {
            get { return planetName; } 
            set { planetName = value; }
        }

        public Continents Continents
        {
            get { return continents; }
            set { continents = value; }
        }
    }
    #region Country Class
    class Country : World
    {
        private string countryName;
        private string capital;
        private CountryLanguages countryLanguages;
        private Currencies currencies;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }
        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }
        public CountryLanguages CountryLanguages
        {
            get { return countryLanguages; }
            set { countryLanguages = value; }
        }
        public Currencies Currencies
        {
            get { return currencies; }
            set { currencies = value; }
        }
        
        public Country()
        {
            CountryName = "Unknown";
            Capital = "Unknow";

        }

        public void SayHi() {

            Console.WriteLine("Hi there Developer ");
        }

        public void SayHi(string country) {

            Console.WriteLine($"Welcome Mirza Arslan from {country}");
        }

    }

    #endregion

    #region Struct which includes private variables
    struct CountryLanguages  
    {
        private string firstLanguage;
        private string secondLanguage;

        public string FirstLanguage 
        { 
            get {return firstLanguage;}
            set { firstLanguage = value; } 
        }
        public string SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }
    }
    #endregion

    #region Enum Continents
    enum Continents
    {

        Asia,
        Africa,
        Antarctica,
        Australia,
        Europe,
        NorthAmerica,
        SouthAmerica
    }
    #endregion

    #region Enum Currencies
    enum Currencies
    {
        USD,
        EUR,
        JPY,
        GBP,
        AUD,
        CAD,
        CHF,
        CNY,
        SEK,
        NZD,
        MXN,
        SGD,
        HKD,
        NOK,
        KRW,
        TRY,
        RUB,
        INR,
        EGP,
        BRL,
        ZAR,
        AED,
        TND,
        SAR,
        RON,
        PLN,
        PKR
    }
    #endregion

    #region
    enum Languages
    {
        Arabic,
        Azerbaijani,
        Bengali,
        Czech,
        Dutch,
        English,
        French,
        German,
        Greek,
        Hindi,
        Hungarian,
        Italian,
        Japanese,
        Javanese,
        Korean,
        Kurdish,
        Malay,
        Mandarin,
        Persian,
        Polish,
        Portuguese,
        Romanian,
        Russian,
        Spanish,
        Swedish,
        Thai,
        Turkish,
        Ukrainian,
        Urdu,
        Vietnamese,
        Zulu
    }
    #endregion

}
