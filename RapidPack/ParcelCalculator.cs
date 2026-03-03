using System.Runtime.InteropServices.JavaScript;

namespace RapidPack;

public class ParcelCalculator
{
    public double Cena(int weight, string parcelType, bool addCheck, int sumaWymiar)
    {
        double price =  10+2*weight;
        if (addCheck)
        {
            price += 15;
        }
        switch (parcelType)
        {
            case "Standard":
            {
                if (sumaWymiar > 150)
                {
                    price += price*1.5;
                }
                
            }
                break;
            case "Glass":
            {
                if (sumaWymiar > 150)
                {
                    price += price*1.5;
                }
                price += 10;
            }
                break;
            case "Paleta":
            {
                price = 100;
            }
                break;
        }
        return price;
    }
}

