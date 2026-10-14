using lab_5.Json;
using lab_5.Toys;
using System.Windows;

namespace lab_5
{
    public partial class MainWindow : Window
    {
        private ToyCatalog _catalog;

        public MainWindow()
        {
            InitializeComponent();

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = System.IO.Path.Combine(documentsPath, "toys_inventory.json");

            _catalog = new ToyCatalog(new JsonFileWriter(), new JsonFileReader(), filePath);
            ToysDataGrid.ItemsSource = _catalog.Toys;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string title = TitleTextBox.Text;
                decimal cost = decimal.Parse(CostTextBox.Text);
                int minAge = int.Parse(MinAgeTextBox.Text);
                int maxAge = int.Parse(MaxAgeTextBox.Text);

                var newToy = new Toy(title, cost, minAge, maxAge);
                _catalog.AddToy(newToy);

                TitleTextBox.Clear();
                CostTextBox.Clear();
                MinAgeTextBox.Clear();
                MaxAgeTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка валідації", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ToysDataGrid.SelectedItem is Toy selectedToy)
            {
                _catalog.DeleteToy(selectedToy);
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть іграшку у таблиці.", "Увага", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            _catalog.SortByCost();
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FilterNTextBox.Text) && string.IsNullOrWhiteSpace(FilterMTextBox.Text))
            {
                _catalog.ResetFilter();
            }
            else if (int.TryParse(FilterNTextBox.Text, out int n) && int.TryParse(FilterMTextBox.Text, out int m))
            {
                _catalog.FilterByAgeRange(n, m);
            }
            else
            {
                MessageBox.Show("Введіть коректні числа для віку N та M.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await _catalog.SaveAsync();
                MessageBox.Show("Дані успішно збережено у файл!", "Збереження", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження: {ex.Message}", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await _catalog.LoadAsync();
                MessageBox.Show("Дані успішно завантажено з файлу!", "Завантаження", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження: {ex.Message}", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}