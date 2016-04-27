using System.Collections.ObjectModel;
using System.Linq;
using BLL.Models;
using BLL.Services;

namespace CurriculumVitae
{
    public class MainWindowVM : ViewModelBase
    {
        private ObservableCollection<Person> _persons;

        /// <summary>
        /// Observable list of Persons
        /// </summary>
        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set
            {
                _persons = value ?? new ObservableCollection<Person>(); //If value is null, initialize empty collection
                OnPropertyChanged(nameof(Persons));
            }
        }

        public MainWindowVM()
        {
            _persons = new ObservableCollection<Person>();
            loadPersons();
        }

        private void loadPersons()
        {
            PersonService.GetPersons();
        }
    }
}