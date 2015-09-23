using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteCashProgramm
{
    class cProduct
    {
        public String sIcon { get; set; }               // Pfad zum Produkticon
        public String sCategory { get; set; }           // Speicher die Kategorie des Produktes
        public String sName { get; set; }               // Name des Produktes
        public String sShortName { get; set; }          // Kurzname des Produktes
        public int iArticleNumber { get; set; }         // Artikelnummer des Produktes
        public float fPrice { get; set; }               // Preis des Produktes

    }

    class cDrink : cProduct
    {
        public String sEinheit { get; set; }            // Einheiten L = Liter / ml = Milliliter / CL
        public float fSize { get; set; }                // Drinkgroesse
        public bool bAlcohol { get; set; }              // Alkoholisches Getränk?s

        public cDrink(int ArtikelNr, String Icon, String Category, String Name, String ShortName, float Size, String Einheit, float Price, bool Alcohol = false)
        {
            this.iArticleNumber = ArtikelNr;
            this.sIcon = Icon;
            this.sCategory = Category;
            this.sName = Name;
            this.sShortName = ShortName;
            this.fSize = Size;
            this.sEinheit = Einheit;
            this.fPrice = Price;
            this.bAlcohol = Alcohol;
        }

        public bool update(int ArtikelNr, String Icon, String Category, String Name, String ShortName, float Size, String Einheit, float Price, bool Alcohol = false)
        {
            this.iArticleNumber = ArtikelNr;
            this.sIcon = Icon;
            this.sCategory = Category;
            this.sName = Name;
            this.sShortName = ShortName;
            this.fSize = Size;
            this.sEinheit = Einheit;
            this.fPrice = Price;
            this.bAlcohol = Alcohol;
            return true;
        }
    }

    class cMeal : cProduct
    {
        public cMeal(int ArtikelNr, String Icon, String Category, String Name, String ShortName, String Einheit, float Price)
        {
            this.iArticleNumber = ArtikelNr;
            this.sIcon = Icon;
            this.sCategory = Category;
            this.sName = Name;
            this.sShortName = ShortName;
            this.fPrice = Price;
        }
    }

}
