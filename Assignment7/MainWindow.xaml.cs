using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Assignment7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random nr = new Random();
        private bool pz = false;

        private void HeavyWork()
        {
            //generate value between 0 and 10
            double timeToSleep = nr.NextDouble() * 10;

            //simulate important work
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(timeToSleep));
        }

        public Task HeavyWorkAsync()
        {
            //run HeavyWork asynchronously
            return Task.Run(() => HeavyWork());
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void AsyncButton(object sender, RoutedEventArgs e)
        {
            TasksAsync();
        }

        async private void TasksAsync()
        {
            Task task1 = HeavyWorkAsync();
            Task task2 = HeavyWorkAsync();
            Task task3 = HeavyWorkAsync();

            TaskTimer();
            LabelText.Content = "Tasks Started: 3";
            await Task.WhenAll(new Task[] { task1, task2, task3 });
            pz = true;
            LabelText.Content = "Tasks Ended: 3";
        }

        async private void TaskTimer()
        {
            await Task.Delay(4000);
            if (!pz)
            {
                LabelText.Content = "Tasks Working";
            }
        }

    }
}
