using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BLL;
using BLL.Services;
using Domain.Models;

namespace CurriculumVitae.ViewModels
{
    public class MainWindowVM : ViewModelBase
    {
        private ObservableCollection<Person> _personItems;
        private IPersonService _personService;
        private ViewModelBase _currentView;

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

        public ViewModelBase CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        public MainWindowVM()
        {
            _currentView = new CVViewVM();
            _personService = new PersonService();
            _personItems = new ObservableCollection<Person>();
        }

        /// <summary>
        /// Load data to fill PersonItems
        /// </summary>
        public void LoadData()
        {
            _personItems = new ObservableCollection<Person>(_personService.LoadPersons());
        }

        private void CreateMockData()
        {
            _personItems.Add(new Person
            {
                Firstname = "Ester",
                Lastname = "Tester",
                Sex = Sex.Female,
                Contacts = new ObservableCollection<Contact>()
                {
                    new Contact()
                    {
                        ContactValue = "skype123",
                        ContactType = new ContactType()
                        {
                            ContactTypeName = "Skype"
                        }
                    }
                }
            });
        }
  
    }
}