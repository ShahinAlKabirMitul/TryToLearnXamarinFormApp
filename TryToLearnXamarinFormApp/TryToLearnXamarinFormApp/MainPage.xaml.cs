﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TryToLearnXamarinFormApp.Annotations;
using Xamarin.Forms;

namespace TryToLearnXamarinFormApp
{
    public class Recipe:INotifyPropertyChanged
    {
        private string _name;
        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        [MaxLength(255)]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public partial class MainPage : ContentPage
    {
        private readonly SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe> _recipes;
        public MainPage()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

        }

        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<Recipe>();
            var recipes = await _connection.Table<Recipe>().ToListAsync();
            _recipes = new ObservableCollection<Recipe>(recipes);
            recipesListView.ItemsSource = _recipes;
            base.OnAppearing();
        }
        async void OnAdd(object sender, System.EventArgs e)
        {
            var recipe = new Recipe() { Name = "Recipe" + Guid.NewGuid() };
            await _connection.InsertAsync(recipe);
            _recipes.Add(recipe);



        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            Recipe recipe = _recipes[0];
            recipe.Name += "Up";
            await _connection.UpdateAsync(recipe);
        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            if (_recipes.Count > 0)
            {
                var recipe = _recipes[0];
                await _connection.DeleteAsync(recipe);
                _recipes.Remove(recipe);
            }
            else
            {
                Task alert = DisplayAlert("Info", "No data for delete", "Ok");
            }
        }
    }
}
