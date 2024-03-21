using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.Models;
using Kreta.Desktop.Repos;
using MenuProject.ViewModels.Base;
using System.Collections.ObjectModel;


namespace MenuProject.ViewModels
{
    public partial class SubjectViewModel : BaseViewModel
    {
        private SubjectRepo _subjectRepo = new();

        [ObservableProperty]
        private ObservableCollection<Subject> _subjects = new();

        [ObservableProperty]
        private Subject _selectedSubject = new();

        public SubjectViewModel()
        {
            UpdateView();
        }

        private void UpdateView()
        {
            Subjects = new ObservableCollection<Subject>(_subjectRepo.FindAll());
        }
    }
}
