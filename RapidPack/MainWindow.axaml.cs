using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RapidPack;

public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
    }
    
    
    private void Submit_OnClick(object? sender, RoutedEventArgs e)
    {
        var opis = "Podsumowanie Zamówienia:\n"+"";
        ShowText.Text = opis;
    }

    private void Weight_OnTextChanged(object? sender, TextChangedEventArgs e)
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