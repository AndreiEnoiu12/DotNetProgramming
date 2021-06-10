using System;
using System.Windows;
using System.Windows.Controls;


namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MultiMediaList mediaTypeList;

        internal static object GetWindow()
        {
            throw new NotImplementedException();
        }

        public MainWindow()
        {
            InitializeComponent();

            mediaTypeList = new MultiMediaList();
            ListMenu.ItemsSource = mediaTypeList.MediaTypes();
        }

        private void AddItemList()
        {
            ListMenu.ItemsSource = null;
            ListMenu.ItemsSource = mediaTypeList.MediaTypes();
        }

        public void AddItem(Multimedia media)
        {
            mediaTypeList.AddNewItem(media);
            AddItemList();
        }


        private void SelectItem(object sender, SelectionChangedEventArgs e)
        {
            if (ListMenu.SelectedItem != null)
            {
                Multimedia song = ListMenu.SelectedItem as Multimedia;
                mainTextBox.Text = String.Format("Title: {0} \r\n" + "Artist: {1} \r\n" + "Genre: {2} \r\n" + "Type: {3}", song.title, song.artist, song.genre, song.type);
            }
        }

        private void AddItemButton(object sender, RoutedEventArgs e)
        {
            AddNew newPanel = new AddNew();
            newPanel.ShowDialog();

            Multimedia title = newPanel.GetNewObject();
            if (title != null)
            {
                AddItem(title);
            }
        }
    }
}
