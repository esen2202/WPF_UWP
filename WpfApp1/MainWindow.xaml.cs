using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using Microsoft.Toolkit.Wpf.UI.XamlHost;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            myInkCanvas.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Pen;
        }

        private void MyCalendar_ChildChanged(object sender, EventArgs e)
        {
            WindowsXamlHost windowsXamlHost = (WindowsXamlHost)sender;

            var calendarView =
                (Windows.UI.Xaml.Controls.CalendarView)windowsXamlHost.Child;

            if (calendarView != null)
            {
                

                calendarView.SelectedDatesChanged += (obj, args) =>
                {
                    if (args.AddedDates.Count > 0)
                    {
                        MessageBox.Show("The user selected a new date: " +
                            args.AddedDates[0].DateTime.ToString());
                    }
                };
            }
        }

        private void MyButton_ChildChanged(object sender, EventArgs e)
        {
            if (myButton.Child is Windows.UI.Xaml.Controls.Button button)
            {
                
                button.Content = "Click me!";
                button.Click += (s, args) =>
                {
                    MessageBox.Show("Hi from UWP Button!");
                };
            }
        }

    }
}

