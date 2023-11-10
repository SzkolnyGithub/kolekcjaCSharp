namespace waznalekcja4cBadowski;
using System.Collections.ObjectModel;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public partial class MainPage : ContentPage
{
    public ObservableCollection<Person> People { get; set; }

    public MainPage()
    {
        InitializeComponent();
        People = new ObservableCollection<Person>
    {
        new Person { Name = "Alice", Age = 30 },
        new Person { Name = "Bob", Age = 25 },
        new Person { Name = "Charlie", Age = 22 }
    };
        BindingContext = this;
    }
    private void Dodaj(object sender, EventArgs e)
    {
        if(Int32.Parse(wiek.Text) <= 0)
        {
            blad.Text = "ERROR: CANNOT INPUT NEGATIVE NUMBERS IN THE 'AGE' SECTION!";
            imie.Text = "";
            wiek.Text = "";
            return;
        } else
        {
            People.Add(new Person { Name = imie.Text, Age = Int32.Parse(wiek.Text) });
            imie.Text = "";
            wiek.Text = "";
        }
    }
    private void Roznica(object sender, SelectedItemChangedEventArgs e)
    {
        string osoba = (e.SelectedItem as Person).Name;
        int wiek = (e.SelectedItem as Person).Age;
        if(wiek > 18)
        {
            DisplayAlert("Różnica wieku", "Różnica wieku osoby " + osoba + " i mojego to " + (wiek - 18), "OK");
        } else
        {
            DisplayAlert("Różnica wieku", "Różnica wieku osoby " + osoba + " i mojego to " + (18 - wiek), "OK");
        }
    }

}

