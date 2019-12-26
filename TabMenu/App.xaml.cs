using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TabMenu
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {
        //creating a database
        static string databaseName = "Zodiac.db";
        //folder path where this database is stored
        static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //the path where the database "zodic.db" is stored
        public static string databasePth = System.IO.Path.Combine(folderPath, databaseName);
    }
}
