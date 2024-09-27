using Microsoft.Maui.Controls;

namespace biblioteka3
{
    public partial class MainPage : ContentPage
    {
        //Zmienne przechowujące liczbę dostępnych egzemplarzy książek.
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
        // Metoda do obsługi wypożyczania książek
        void BorrowBook(object sender, EventArgs e)
        {
            
            int id;
            if (!int.TryParse(Wypozycz.Text, out id))
            {
                DisplayAlert("Error! ", "Niepoprawna wartość", "OK");
                return;
            }

            switch (id)
            {
                case 1:
                    if (potopIlosc > 0)
                        potopIlosc -= 1;
                    else
                        DisplayAlert("Brak", "Nie mamy tej książki dostępnej w bibliotece", "OK");
                    break;
                case 2:
                    if (tadeuszIlosc > 0)
                        tadeuszIlosc -= 1;
                    else
                        DisplayAlert("Brak", "Nie mamy tej książki dostępnej w bibliotece", "OK");
                    break;
                case 3:
                    if (zbrodniaIlosc > 0)
                        zbrodniaIlosc -= 1;
                    else
                        DisplayAlert("Brak", "Nie mamy tej książki dostępnej w bibliotece", "OK");
                    break;
                default:
                    DisplayAlert("Error!", "Nie ma u nas książki o takim ID", "OK");
                    break;
            }


            UpdateBooksCount();
        }

        // Metoda do obsługi oddawania książek
        void ReturnBook(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(Oddaj.Text, out id))
            {
                DisplayAlert("Error!", "Niepoprawna wartość", "OK");
                return;
            }

            switch (id)
            {
                case 1:
                    potopIlosc += 1;
                    DisplayAlert("Dzękujemy", " Dzękujemy za zwrócenie nam książki.Zapraszamy ponownie.", "OK");
                    break;
                case 2:
                    tadeuszIlosc += 1;
                    DisplayAlert("Dzękujemy", "Dzękujemy za zwrócenie nam książki.Zapraszamy ponownie.", "OK");
                    break;
                case 3:
                    zbrodniaIlosc += 1;
                    DisplayAlert("Dzękujemy", "Dzękujemy za zwrócenie nam książki.Zapraszamy ponownie.", "OK");
                    break;
                default:
                    DisplayAlert("Error!", "Nie ma u nas książki o takim ID", "OK");
                    break;
            }

            UpdateBooksCount();
        }
    }
}