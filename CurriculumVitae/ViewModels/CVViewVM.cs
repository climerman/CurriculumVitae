using System.Collections.ObjectModel;
using BLL;
using BLL.Services;
using Domain.Models;

namespace CurriculumVitae.ViewModels
{
    public class CVViewVM : ViewModelBase
    {
        private IPersonService _personService;
        private ObservableCollection<Contact> _contactItems;
        private ObservableCollection<Education> _educationItems;
        private ObservableCollection<Experience> _experienceItems;
        private ObservableCollection<Skill> _skillItems;

        #region Properties

        public Person Person { get; set; }

        public ObservableCollection<Contact> ContactItems
        {
            get { return _contactItems; }
            set
            {
                _contactItems = value; //If value is null, initialize empty collection
                OnPropertyChanged(nameof(ContactItems));
            }
        }

        public ObservableCollection<Education> EducationItems
        {
            get { return _educationItems; }
            set
            {
                _educationItems = value;
                OnPropertyChanged(nameof(EducationItems));
            }
        }

        public ObservableCollection<Experience> ExperienceItems
        {
            get { return _experienceItems; }
            set
            {
                _experienceItems = value;
                OnPropertyChanged(nameof(ExperienceItems));
            }
        }

        public ObservableCollection<Skill> SkillItems
        {
            get { return _skillItems;}
            set
            {
                _skillItems = value;
                OnPropertyChanged(nameof(SkillItems));
            }
        }

#endregion

        public CVViewVM()
        {
            _personService = new PersonService();
            _contactItems = new ObservableCollection<Contact>();
            _educationItems = new ObservableCollection<Education>();
            _experienceItems = new ObservableCollection<Experience>();
            _skillItems = new ObservableCollection<Skill>();
        }

        private void LoadPersonData()
        {
        }
    }
}