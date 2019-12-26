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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TabMenu.classes;

namespace TabMenu
{
    enum ZodiacSigns
    {
        Aries, Taures, Gemini, Cancer, Leo, Virgo, Libra, Sccorpius, Sagittarius, Capricornus, Aquarius, Pisces

    }
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {

        private Dictionary<string, DateTime> DateMap = new Dictionary<string, DateTime>
        {
            {"AriesStart",new DateTime(2019,3,21) },{"AriesEnd",new DateTime(2019,4,20)},{"TauresStart",new DateTime(2019,4,21)}, {"TauresEnd",new DateTime(2019,5,21) },
            {"GeminiStart",new DateTime(2019,5,22) },{"GeminiEnd",new DateTime(2019,6,21)},{"CancerStart",new DateTime(2019,6,22)}, {"CancerEnd",new DateTime(2019,7,23) },
            {"LeoStart",new DateTime(2019,7,24) },{"LeoEnd",new DateTime(2019,8,23)},{"VirgoStart",new DateTime(2019,8,24)}, {"VirgoEnd",new DateTime(2019,9,23) },
            {"LibraStart",new DateTime(2019,9,24) },{"LibraEnd",new DateTime(2019,10,23)},{"ScorpiusStart",new DateTime(2019,10,24)}, {"ScorpiusEnd",new DateTime(2019,11,22) },
            {"SagittariusStart",new DateTime(2019,11,23) },{"SagittariusEnd",new DateTime(2019,12,21)},{"CapricornusStart",new DateTime(2019,12,22)}, {"CapricornusEnd",new DateTime(2019,1,20) },
            {"AquariusStart",new DateTime(2019,1,21) },{"AquariusEnd",new DateTime(2019,2,19)},{"PiscesStart",new DateTime(2019,2,20)}, {"PiscesEnd",new DateTime(2019,3,20) }



        };
     




        List<ZodiacInfo> zodiacs;
        //moke data
        public List<String> zodiacInfo = new List<String>();
        public List<String> zodiacImages = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

            //just to make sure zodiacs is not null;
            zodiacs = new List<ZodiacInfo>();

            zodiacImages.Add("E:/class/3rd/c#/c#workspace/Zodiac/Zodiac/img/ARIES-PROFILE.webp");
            zodiacImages.Add("E:/class/3rd/c#/c#workspace/Zodiac/Zodiac/img/TAURUS-PROFILE.webp");
            zodiacImages.Add("E:/class/3rd/c#/c#workspace/Zodiac/Zodiac/img/GEMINI-PROFILE.webp");
            zodiacImages.Add("E:/class/3rd/c#/c#workspace/Zodiac/Zodiac/img/CANCER-PROFILE.webp");
            zodiacImages.Add("E:/class/3rd/c#/c#workspace/Zodiac/Zodiac/img/LEO-PROFILE.webp");
            zodiacImages.Add("E:/class/3rd/c#/c#workspace/Zodiac/Zodiac/img/VIRGO-PROFILE.webp");
            zodiacImages.Add("E:/class/3rd/c#/c#workspace/Zodiac/Zodiac/img/LIBRA-PROFILE.webp");
            zodiacImages.Add("E:/class/3rd/c#/c#workspace/Zodiac/Zodiac/img/SCORPIO-PROFILE.webp");
            zodiacImages.Add("E:/class/3rd/c#/c#workspace/Zodiac/Zodiac/img/SAGITTARIUS-PROFILE.webp");
            zodiacImages.Add("E:/class/3rd/c#/c#workspace/Zodiac/Zodiac/img/CAPRICORN-PROFILE.webp");
            zodiacImages.Add("E:/class/3rd/c#/c#workspace/Zodiac/Zodiac/img/AQUARIUS-PROFILE.webp");
            zodiacImages.Add("E:/class/3rd/c#/c#workspace/Zodiac/Zodiac/img/PISCES-PROFILE.webp");


            ReadDatabase();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            switch (index)
            {
                case 0:

                    GridMain.Background = Brushes.White;
                    datePicker.Visibility = Visibility.Visible;
                    datePickerDescription.Visibility = Visibility.Visible;

                    aboutZodiac.Visibility = Visibility.Hidden;
                    detailed_zodiac_info.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    GridMain.Background = Brushes.White;
                    datePicker.Visibility = Visibility.Hidden;
                    detailed_zodiac_info.Visibility = Visibility.Hidden;
                    datePickerDescription.Visibility = Visibility.Hidden;
                    starter_zoidac_Image.Visibility = Visibility.Visible;
                    aboutZodiac.Visibility = Visibility.Visible;
                    break;

            }
            
        }

        private void Zodiac_day_handler(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            //for (int i = 0; i < zodiacInfo.Count; i++)
            //{
            //    zodiacInfoTextBlock.Text = zodiacInfo[i];
            //}

            switch (index)
            {
                case 0:

                    ZoidacInfoImage.Source = new BitmapImage(new Uri(zodiacImages[index]));
                    //ZoidacInfoImage.source =new bitmapimage(new uri($"{x}") );

                    detailed_zodiac_info.Visibility = Visibility.Visible;
                    starter_zoidac_Image.Visibility = Visibility.Hidden;
                    datePickerDescription.Visibility = Visibility.Hidden;
                    break;
                case 1:

                    ZoidacInfoImage.Source = new BitmapImage(new Uri(zodiacImages[index]));
                    detailed_zodiac_info.Visibility = Visibility.Visible;
                    starter_zoidac_Image.Visibility = Visibility.Hidden;
                    break;
                case 2:

                    ZoidacInfoImage.Source = new BitmapImage(new Uri(zodiacImages[index]));
                    detailed_zodiac_info.Visibility = Visibility.Visible;
                    starter_zoidac_Image.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    ZoidacInfoImage.Source = new BitmapImage(new Uri(zodiacImages[index]));
                    detailed_zodiac_info.Visibility = Visibility.Visible;
                    starter_zoidac_Image.Visibility = Visibility.Hidden;
                    break;
                case 4:
                    ZoidacInfoImage.Source = new BitmapImage(new Uri(zodiacImages[index]));
                    detailed_zodiac_info.Visibility = Visibility.Visible;
                    starter_zoidac_Image.Visibility = Visibility.Hidden;
                    break;
                case 5:
                    ZoidacInfoImage.Source = new BitmapImage(new Uri(zodiacImages[index]));
                    detailed_zodiac_info.Visibility = Visibility.Visible;
                    starter_zoidac_Image.Visibility = Visibility.Hidden;
                    break;
                case 6:
                    ZoidacInfoImage.Source = new BitmapImage(new Uri(zodiacImages[index]));
                    detailed_zodiac_info.Visibility = Visibility.Visible;
                    starter_zoidac_Image.Visibility = Visibility.Hidden;
                    break;
                case 7:
                    ZoidacInfoImage.Source = new BitmapImage(new Uri(zodiacImages[index]));
                    detailed_zodiac_info.Visibility = Visibility.Visible;
                    starter_zoidac_Image.Visibility = Visibility.Hidden;
                    break;
                case 8:
                    ZoidacInfoImage.Source = new BitmapImage(new Uri(zodiacImages[index]));
                    detailed_zodiac_info.Visibility = Visibility.Visible;
                    starter_zoidac_Image.Visibility = Visibility.Hidden;
                    break;
                case 9:
                    ZoidacInfoImage.Source = new BitmapImage(new Uri(zodiacImages[index]));
                    detailed_zodiac_info.Visibility = Visibility.Visible;
                    starter_zoidac_Image.Visibility = Visibility.Hidden;
                    break;
                case 10:
                    ZoidacInfoImage.Source = new BitmapImage(new Uri(zodiacImages[index]));
                    detailed_zodiac_info.Visibility = Visibility.Visible;
                    starter_zoidac_Image.Visibility = Visibility.Hidden;
                    break;
                case 11:
                    ZoidacInfoImage.Source = new BitmapImage(new Uri(zodiacImages[index]));
                    detailed_zodiac_info.Visibility = Visibility.Visible;
                    starter_zoidac_Image.Visibility = Visibility.Hidden;
                    break;

            }

        }

        private void powerButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            NewEditWindow newEditWindow = new NewEditWindow();
            newEditWindow.ShowDialog();

            //to get immidiate update in my main window
            ReadDatabase();

        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //TextBox searchTextBox = sender as TextBox;
            
           
            var filterdList = zodiacs.Where(c => c.Title.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
            zodiacInfoListView.ItemsSource = filterdList;

        }

        public void ReadDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.databasePth))
            {
                conn.CreateTable<ZodiacInfo>();
                //read table
                zodiacs = (conn.Table<ZodiacInfo>().ToList()).OrderBy(c => Title).ToList();
                if (zodiacs != null)
                {
                    zodiacInfoListView.ItemsSource = zodiacs;
                }
            }
        }

        private void zodiacInfoListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ZodiacInfo selectedInfo = (ZodiacInfo)zodiacInfoListView.SelectedItem;
            if (selectedInfo != null)
            {
                ZodiacEditWindow zodiacEditWindow = new ZodiacEditWindow(selectedInfo);
                zodiacEditWindow.ShowDialog();
                ReadDatabase();
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            //dateTimePicker1.Format = DateTimePickerFormat.Custom
            //dateTimePicker1.CustomFormat = "MMMM yyyy" 'or whatever you want

            var picker = sender as DatePicker;

            DateTime? date = picker.SelectedDate;
            if (date == null)
            {
                DateTextBlock.Text = "No date selected";
            }
            else
            {
                if (getZodiacSign(DateTime.Parse(date.Value.ToString())) == null)
                {
                    DateTextBlock.Text = null;
                }
                //DateTextBlock.Text= getZodiacSign();
                var myTime = DateTime.Parse(date.Value.ToShortDateString());
                DateTextBlock.Text = getZodiacSign(myTime);
                zodiacDatePickerListView.Visibility = Visibility.Visible;


            }



        }
        private string getZodiacSign(DateTime date)
        {
            if (date >= DateMap["AriesStart"] && date <= DateMap["AriesEnd"])
            {
               

               // zSign.Source = new BitmapImage(new Uri(zodiacImages[0]));

                var text = "Aries";
                var filterdList = zodiacs.Where(c => c.Title.ToLower().Contains(text.ToLower())).ToList();
                zodiacDatePickerListView.ItemsSource = filterdList;
                return ZodiacSigns.Aquarius.ToString();

            }
            else if (date >= DateMap["TauresStart"] && date <= DateMap["TauresEnd"])
            {

                // zSign.Source = new BitmapImage(new Uri(zodiacImages[1]));

                var text = "Taurus";
                var filterdList = zodiacs.Where(c => c.Title.ToLower().Contains(text.ToLower())).ToList();
                zodiacDatePickerListView.ItemsSource = filterdList;
                return ZodiacSigns.Taures.ToString();
            }
            else if (date >= DateMap["GeminiStart"] && date <= DateMap["GeminiEnd"])
            {


                //zSign.Source = new BitmapImage(new Uri(zodiacImages[2]));

                var text = "Gemini";
                var filterdList = zodiacs.Where(c => c.Title.ToLower().Contains(text.ToLower())).ToList();
                zodiacDatePickerListView.ItemsSource = filterdList;
                return ZodiacSigns.Gemini.ToString();
            }
            else if (date >= DateMap["CancerStart"] && date <= DateMap["CancerEnd"])
            {

                //zSign.Source = new BitmapImage(new Uri(zodiacImages[3]));

                var text = "Cancer";
                var filterdList = zodiacs.Where(c => c.Title.ToLower().Contains(text.ToLower())).ToList();
                zodiacDatePickerListView.ItemsSource = filterdList;
                return ZodiacSigns.Cancer.ToString();
            }
            else if (date >= DateMap["LeoStart"] && date <= DateMap["LeoEnd"])
            {


               // zSign.Source = new BitmapImage(new Uri(zodiacImages[4]));

                var text = "Leo";
                var filterdList = zodiacs.Where(c => c.Title.ToLower().Contains(text.ToLower())).ToList();
                zodiacDatePickerListView.ItemsSource = filterdList;
                return ZodiacSigns.Leo.ToString();
            }
            else if (date >= DateMap["VirgoStart"] && date <= DateMap["VirgoEnd"])
            {


               // zSign.Source = new BitmapImage(new Uri(zodiacImages[5]));

                var text = "Virgo";
                var filterdList = zodiacs.Where(c => c.Title.ToLower().Contains(text.ToLower())).ToList();
                zodiacDatePickerListView.ItemsSource = filterdList;
                return ZodiacSigns.Virgo.ToString();
            }
            else if (date >= DateMap["LibraStart"] && date <= DateMap["LibraEnd"])
            {


               // zSign.Source = new BitmapImage(new Uri(zodiacImages[6]));

                var text = "Libra";
                var filterdList = zodiacs.Where(c => c.Title.ToLower().Contains(text.ToLower())).ToList();
                zodiacDatePickerListView.ItemsSource = filterdList;
                return ZodiacSigns.Libra.ToString();
            }
            else if (date >= DateMap["ScorpiusStart"] && date <= DateMap["ScorpiusEnd"])
            {

               // zSign.Source = new BitmapImage(new Uri(zodiacImages[7]));

                var text = "Scorpio";
                var filterdList = zodiacs.Where(c => c.Title.ToLower().Contains(text.ToLower())).ToList();
                zodiacDatePickerListView.ItemsSource = filterdList;
                return ZodiacSigns.Sccorpius.ToString();
            }
            else if (date >= DateMap["SagittariusStart"] && date <= DateMap["SagittariusEnd"])
            {


               // zSign.Source = new BitmapImage(new Uri(zodiacImages[8]));

                var text = "Sagittarius";
                var filterdList = zodiacs.Where(c => c.Title.ToLower().Contains(text.ToLower())).ToList();
                zodiacDatePickerListView.ItemsSource = filterdList;
                return ZodiacSigns.Sagittarius.ToString();
            }
            else if (date >= DateMap["CapricornusStart"] && date <= DateMap["CapricornusEnd"])
            {


               // zSign.Source = new BitmapImage(new Uri(zodiacImages[9]));

                var text = "Capricorn";
                var filterdList = zodiacs.Where(c => c.Title.ToLower().Contains(text.ToLower())).ToList();
                zodiacDatePickerListView.ItemsSource = filterdList;
                return ZodiacSigns.Capricornus.ToString();
            }
            else if (date >= DateMap["AquariusStart"] && date <= DateMap["AquariusEnd"])
            {


               // zSign.Source = new BitmapImage(new Uri(zodiacImages[10]));

                var text = "Aquarius";
                var filterdList = zodiacs.Where(c => c.Title.ToLower().Contains(text.ToLower())).ToList();
                zodiacDatePickerListView.ItemsSource = filterdList;
                return ZodiacSigns.Aquarius.ToString();
            }
            else if (date >= DateMap["PiscesStart"] && date <= DateMap["PiscesEnd"])
            {


               // zSign.Source = new BitmapImage(new Uri(zodiacImages[11]));

                var text = "Pisces";
                var filterdList = zodiacs.Where(c => c.Title.ToLower().Contains(text.ToLower())).ToList();
                zodiacDatePickerListView.ItemsSource = filterdList;
                return ZodiacSigns.Pisces.ToString();
            }

            return null;
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            myCalander.Text = "";
            zodiacDatePickerListView.Visibility = Visibility.Hidden;
        }
    }
}
