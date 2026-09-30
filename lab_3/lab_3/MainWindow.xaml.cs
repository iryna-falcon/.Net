using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace lab_3
{
    public partial class MainWindow : Window
    {
        private List<ArtWork> _artCollection = new List<ArtWork>();

        public MainWindow()
        {
            InitializeComponent();

            ArtTypeComboBox.Items.Add("Картина");
            ArtTypeComboBox.Items.Add("Скульптура");
            ArtTypeComboBox.SelectedIndex = 0;

            ArtTypeComboBox.SelectionChanged += ArtTypeComboBox_SelectionChanged;
        }

        private void ArtTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SpecificFieldLabel == null) return;

            if (ArtTypeComboBox.SelectedIndex == 0)
            {
                SpecificFieldLabel.Content = "Техніка:";
            }
            else
            {
                SpecificFieldLabel.Content = "Матеріал:";
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string title = TitleTextBox.Text;
                int year = int.Parse(YearTextBox.Text);
                string author = AuthorTextBox.Text;
                double value = double.Parse(ValueTextBox.Text);
                string specificInfo = SpecificTextBox.Text;

                ArtWork newArt;

                if (ArtTypeComboBox.SelectedIndex == 0)
                {
                    newArt = new Painting(title, year, author, value, specificInfo);
                }
                else
                {
                    newArt = new Sculpture(title, year, author, value, specificInfo);
                }

                _artCollection.Add(newArt);

                ArtListBox.Items.Add($"[{ArtTypeComboBox.SelectedItem}] {newArt.Title} ({newArt.CreationYear}) - Автор: {newArt.Author} | Вартість: {newArt.Value} грн");

                UpdateAnalytics();

                TitleTextBox.Clear();
                YearTextBox.Clear();
                AuthorTextBox.Clear();
                ValueTextBox.Clear();
                SpecificTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка вводу: перевірте правильність заповнення полів (рік та вартість мають бути числами).\n\nДеталі: " + ex.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UpdateAnalytics()
        {
            double total = ArtAnalysis.GetTotalValueBefore1900(_artCollection);

            TotalValueTextBlock.Text = $"Загальна вартість творів до 1900 року: {total} грн";
        }
    }
}