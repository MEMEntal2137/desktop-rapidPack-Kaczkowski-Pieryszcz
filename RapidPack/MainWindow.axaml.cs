using System;
using System.Security.Authentication.ExtendedProtection;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RapidPack;

public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
    }
    
    ParcelCalculator parcelCalculator = new();
    public void Submit_OnClick(object? sender, RoutedEventArgs e)
    {
        int suma = int.Parse(Width.Text??"0")+int.Parse(Height.Text??"0")+int.Parse(Deep.Text??"0");
        string combobox;
        switch (TypeOfPackage.SelectedIndex)
        {
            case 0:
            {
                combobox = "Standard";
            }
                break;
            case 2:
            {
                combobox = "Glass";
            }
                break;
            case 1:
            {
                combobox = "Paleta";
            }
                break;
            default:
            {
                combobox = "Standard";
            }
                break;
        }
        double price = parcelCalculator.Cena(int.Parse(Weight.Text??"0"), combobox, Express.IsChecked ?? false, suma  );
        string express;
        if (Express.IsChecked==true)
        {
            express = "Tak";
        }
        else
        {
            express = "Nie";
        }
        var opis = $"Podsumowanie Zamówienia:\nCena paczki: {price}zł\nWymiary paczki: {Width.Text}cm x {Height.Text}cm x {Deep.Text}cm\nWaga paczki: {Weight.Text} kg\nRodzaj paczki: {combobox}\nExpress: {express}";
        ShowText.Text = opis;
    }

    public void Weight_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (Weight.Text == "")
        {
            int waga = 0;
            WagaCheck.Text = "Waga paczki (w kg):";
        }
        else
        {
            int waga = int.Parse(Weight.Text ?? "0");
            if (waga > 30)
            {
                WagaCheck.Text = "Błąd: Waga paczki nie może przekroczyć 30 kg";
                Weight.Text = "30";
            }
            else if (waga <= 30)
            {
                WagaCheck.Text = "Waga paczki (w kg):";
            }
            else
            {
                WagaCheck.Text = "Użyj liczby!";
            }
        }
    }
}