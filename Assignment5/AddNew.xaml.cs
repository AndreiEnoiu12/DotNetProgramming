using System.Windows;
using System.Windows.Controls;


namespace Assignment5
{
    /// <summary>
    /// Interaction logic for AddNew.xaml
    /// </summary>
    public partial class AddNew : Window
    {
        private bool booler;

        public AddNew()
        {
            InitializeComponent();

            booler = false;
        }


        private void SaveButton(object sender, RoutedEventArgs e)
        {
            booler = true;
            this.Close();
        }


        public Multimedia GetNewObject()
        {
            if (booler == true)
            {
                return new Multimedia(TitleField.Text, ArtistField.Text, GenreField.Text, ((ComboBoxItem)TypeBox.SelectedItem).Content.ToString());
            }
            else return null;
        }


        private void BackButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
