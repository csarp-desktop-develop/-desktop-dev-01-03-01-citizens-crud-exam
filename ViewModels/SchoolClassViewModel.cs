using CommunityToolkit.Mvvm.ComponentModel;
using MenuProject.Models;
using MenuProject.Repos;
using MenuProject.ViewModels.Base;
using System.Collections.ObjectModel;


namespace MenuProject.ViewModels
{
    public partial class SchoolClassViewModel : BaseViewModel
    {
        private SchoolClassRepo _schoolClassRepo = new();

        [ObservableProperty]
        private ObservableCollection<SchoolClass> _schoolClasses = new();

        [ObservableProperty]
        private SchoolClass _selectedSchoolClass = new();

        public SchoolClassViewModel()
        {
            UpdateView();
        }

        private void UpdateView()
        {
            SchoolClasses = new ObservableCollection<SchoolClass>(_schoolClassRepo.FindAll());
        }
    }
}
