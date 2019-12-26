using SQLite;
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
using System.Windows.Shapes;
using TabMenu.classes;

namespace TabMenu
{
    /// <summary>
    /// Interaction logic for NewEditWindow.xaml
    /// </summary>
    public partial class NewEditWindow : Window
    {
       
        public NewEditWindow()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            ZodiacInfo zodiacInfo = new ZodiacInfo()
            {
                Title = editNameTextBox.Text,
                Description = editDescriptionTextBox.Text,
            };
            //connect to database
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePth))
            {
                connection.CreateTable<ZodiacInfo>();

                connection.Insert(zodiacInfo);         
            }
           

            Close();
        }

        private void editPowerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
