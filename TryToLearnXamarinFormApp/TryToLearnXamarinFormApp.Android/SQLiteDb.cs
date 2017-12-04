using System;
using System.IO;
using SQLite;

using TryToLearnXamarinFormApp.Droid;
using Xamarin.Forms;
[assembly: Dependency(typeof(SQLiteDb))]
namespace TryToLearnXamarinFormApp.Droid
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}