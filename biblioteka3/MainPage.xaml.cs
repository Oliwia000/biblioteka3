using Microsoft.Maui.Controls;

namespace biblioteka3
{
    public partial class MainPage : ContentPage
    {
        int potopIlosc = 2;
        int tadeuszIlosc = 1;
        int zbrodniaIlosc = 4;

        public MainPage()
        {
            InitializeComponent();
            UpdateBooksCount();
        }

        void UpdateBooksCount()
        {
            PotopIlosc.Text = potopIlosc.ToString();
            TadeuszIlosc.Text = tadeuszIlosc.ToString();
            ZbrodniaIlosc.Text = zbrodniaIlosc.ToString();
        }

        void BorrowBook(object sender, EventArgs e)
        {
            // Poprawione przypisanie zmiennej id
            int id;
            if (!int.TryParse(Wypozycz.Text, out id))
            {
                DisplayAlert("Nieprawidłowe ID", "", "OK");
                return;
            }

            switch (id)
            {
                case 1:
                    if (potopIlosc > 0)
                        potopIlosc -= 1;
                    else
                        DisplayAlert("Książki już nie ma!", "", "OK");
                    break;
                case 2:
                    if (tadeuszIlosc > 0)
                        tadeuszIlosc -= 1;
                    else
                        DisplayAlert("Książki już nie ma!", "", "OK");
                    break;
                case 3:
                    if (zbrodniaIlosc > 0)
                        zbrodniaIlosc -= 1;
                    else
                        DisplayAlert("Książki już nie ma!", "", "OK");
                    break;
                default:
                    DisplayAlert("Książka o podanym ID nie istnieje!", "", "OK");
                    break;
            }


            UpdateBooksCount();
        }

        void ReturnBook(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(Oddaj.Text, out id))
            {
                DisplayAlert("Nieprawidłowe ID", "", "OK");
                return;
            }

            switch (id)
            {
                case 1:
                    potopIlosc += 1;
                    DisplayAlert("Dzięki za oddanie książki", "", "OK");
                    break;
                case 2:
                    tadeuszIlosc += 1;
                    DisplayAlert("Dzięki za oddanie książki", "", "OK");
                    break;
                case 3:
                    zbrodniaIlosc += 1;
                    DisplayAlert("Dzięki za oddanie książki", "", "OK");
                    break;
                default:
                    DisplayAlert("Książka o podanym ID nie istnieje!", "", "OK");
                    break;
            }

            UpdateBooksCount();
        }
    }
}