using System.Collections.ObjectModel;
using BLL.Models;
using BLL.Services;

namespace CurriculumVitae.ViewModels
{
    public class MainWindowVM : ViewModelBase
    {
        private ObservableCollection<Person> _personItems;
        private ObservableCollection<Contact> _contactItems; 

        /// <summary>
        /// Observable list of PersonItems
        /// </summary>
        public ObservableCollection<Person> PersonItems
        {
            get { return _personItems; }
            set
            {
                _personItems = value; //If value is null, initialize empty collection
                OnPropertyChanged(nameof(PersonItems));
            }
        }

        public ObservableCollection<Contact> ContactItems
        {
            get
            {
                return _contactItems;
            }
            set
            {
                _contactItems = value;
                OnPropertyChanged(nameof(ContactItems));
            }
        }

        public MainWindowVM()
        {
            _personItems = new ObservableCollection<Person>();
        }

        public void LoadData()
        {
            //LoadPersons();
            CreateMockData();
        }

        private void CreateMockData()
        {
            _personItems.Add(new Person
            {
                Firstname = "Ester",
                Lastname = "Tester",
                Sex = Sex.Female,
            });
        }

        private void LoadPersons()
        {
            PersonService.GetPersons();
        }
    }
}