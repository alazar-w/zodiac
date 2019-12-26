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
    /// Interaction logic for ZodiacEditWindow.xaml
    /// </summary>
    public partial class ZodiacEditWindow : Window
    {
        ZodiacInfo info;
       
        public ZodiacEditWindow(ZodiacInfo zodiacInfo)
        {
            InitializeComponent();
            this.info = zodiacInfo;

            zodiacEditNameTextBox.Text = info.Title;
            zodiacDescriptionTextBox.Text = info.Description;
            

        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            info.Title = zodiacEditNameTextBox.Text;
            info.Description = zodiacDescriptionTextBox.Text;

            using (SQLiteConnection conn = new SQLiteConnection(App.databasePth))
            {
                conn.Update(info);
            }
            Close();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.databasePth))
            {
                conn.Delete(info);
            }
            Close();
        }

        private void editPowerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cancleButoon_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
