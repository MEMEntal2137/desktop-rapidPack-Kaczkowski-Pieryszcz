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
        int suma = int.Parse(TextBoxWidth.Text)+int.Parse(Height.Text)+int.Parse(Deep.Text);
        string combobox = (TypeOfPackage.SelectionBoxItem as ComboBoxItem)?.Content?.ToString() ?? "Standard";
        double price = parcelCalculator.Cena(int.Parse(WagaCheck.Text), combobox, Express.IsChecked ?? false, suma  );
        var opis = $"Podsumowanie Zamówienia:\n {price}";
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