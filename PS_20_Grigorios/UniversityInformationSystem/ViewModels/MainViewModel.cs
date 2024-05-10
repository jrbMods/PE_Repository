using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Linq;
using UniversityInformationSystem.ViewModels;

namespace UniversityInformationSystem.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Course> _courses;

        public ObservableCollection<Course> Courses
        {
            get { return _courses; }
            set
            {
                _courses = value;
                RaisePropertyChanged(nameof(Courses));
            }
        }

        public MainViewModel()
        {
            using (var context = new UniversityDbContext())
            {
                Courses = new ObservableCollection<Course>(context.Courses.ToList());
            }
        }
    }
}
