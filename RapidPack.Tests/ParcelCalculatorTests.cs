using Xunit;
using RapidPack;
namespace RapidPack.Tests;

public class ParcelCalculatorTests
{
    [Fact]
    public void ShouldNotCalculateParcel()
    {
        int weight= 35;
        string parcelType = "Standard";
        bool addCheck = false;
        int sumaWymiar = 100;
        ParcelCalculator parcelCalculator = new();
        double result = parcelCalculator.Cena(weight, parcelType, addCheck , sumaWymiar);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Gabaryt()
    {
        int weight= 30;
        string parcelType = "Standard";
        bool addCheck = false;
        int sumaWymiar = 160;
        ParcelCalculator parcelCalculator = new();
        double result = parcelCalculator.Cena(weight, parcelType, addCheck, sumaWymiar);
        Assert.Equal(175, result);
    }
    [Fact]
    public void Paleta()
    {
        int weight= 30;
        string parcelType = "Paleta";
        bool addCheck = false;
        int sumaWymiar = 100;
        ParcelCalculator parcelCalculator = new();
        double result = parcelCalculator.Cena(weight, parcelType, addCheck, sumaWymiar);
        Assert.Equal(100, result);
    }
    [Fact]
    public void Express()
    {
        int weight= 30;
        string parcelType = "Standard";
        bool addCheck = true;
        int sumaWymiar = 100;
        ParcelCalculator parcelCalculator = new();
        double result = parcelCalculator.Cena(weight, parcelType, addCheck, sumaWymiar);
        Assert.Equal(85, result);
    }
}