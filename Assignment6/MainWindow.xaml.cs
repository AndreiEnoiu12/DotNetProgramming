using System;
using System.Windows;
using System.Windows.Threading;

namespace Assignment6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer dispTime;
        System.Windows.Forms.OpenFileDialog filesDialog = new System.Windows.Forms.OpenFileDialog();

        public MainWindow()
        {
            InitializeComponent();
            dispTime = new DispatcherTimer();

            dispTime.Interval = TimeSpan.FromSeconds(0.05);
        }


        private void OpenButton(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        private void PlayButton(object sender, RoutedEventArgs e)
        {
            FileMedia.Play();

        }

        private void PauseButton(object sender, RoutedEventArgs e)
        {
            FileMedia.Pause();
        }

        private void StopButton(object sender, RoutedEventArgs e)
        {
            FileMedia.Stop();
        }


        private void PlayTimer(object sender, EventArgs e)
        {
            if (FileMedia.NaturalDuration.HasTimeSpan && FileMedia.Source != null)
            {
                ProgressBar.Minimum = 0;

                ProgressBar.Maximum = FileMedia.NaturalDuration.TimeSpan.TotalSeconds;
                ProgressBar.Value = FileMedia.Position.TotalSeconds;
            }
        }


        private void OpenFile()
        {
            try
            {
                filesDialog.ShowDialog();
                FileMedia.Source = new Uri(filesDialog.FileName);
                FileMedia.Play();

                FileName.Content = FileMedia.Source.Segments[FileMedia.Source.Segments.Length - 1];
                dispTime.Tick += PlayTimer;
                dispTime.Start();
            } catch (Exception e)
                   {
                    //Error
                   }
        }


        private void ErrorFile(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("Error! Can't load this Media!" + e.ErrorException.Message);
        }
    }
}
