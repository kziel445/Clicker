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
using Clicker.API;
using Clicker.Tools;


namespace Clicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // register KeyDown
            this.KeyDown += OnKeyDownHandler;
            //
            LabelController.ShowInLabel(Coordinates, ShowPointerPosition.MousePosition().ToString());
        }

        private void Get_Cursor_Position_Click(object sender, RoutedEventArgs e)
        {
            ButtonController.Get_Cursor_Position_OnClick(Coordinates);
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.R && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control) 
            {
                MessageBox.Show("Ctrl + R was pressed!");
            }
        }
    }
}
