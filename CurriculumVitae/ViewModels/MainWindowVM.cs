using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                Contacts = new List<Contact>()
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

        private void LoadPersons()
        {
            _personService.GetAll();
        }
    }
}