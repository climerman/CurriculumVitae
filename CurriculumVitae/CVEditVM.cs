using System;
using System.Collections.ObjectModel;
using BLL.Models;

namespace CurriculumVitae
{
    public class CVEditVM : ViewModelBase
    {
        private Person _person;
        private ObservableCollection<Contact> _contacts;
        private ObservableCollection<Education> _educations;
        private ObservableCollection<Experience> _experiences;
        private ObservableCollection<Skill> _skills;

        public Person Person { get; set; }

        #region Properties

        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts;}
            set
            {
                _contacts = value ?? new ObservableCollection<Contact>();
                OnPropertyChanged(nameof(Contacts));
            }
        }

        public ObservableCollection<Education> Educations
        {
            get { return _educations; }
            set
            {
                _educations = value ?? new ObservableCollection<Education>();
                OnPropertyChanged(nameof(Educations));
            }
        }

        public ObservableCollection<Experience> Experiences
        {
            get { return _experiences;}
            set
            {
                _experiences = value ?? new ObservableCollection<Experience>();
                OnPropertyChanged(nameof(Experiences));
            }
        }

        public ObservableCollection<Skill> Skills
        {
            get { return _skills;}
            set
            {
                _skills = value ?? new ObservableCollection<Skill>();
                OnPropertyChanged(nameof(Skills));
            }
        }

#endregion

        public CVEditVM()
        {
            _contacts = new ObservableCollection<Contact>();
            _educations = new ObservableCollection<Education>();
            _experiences = new ObservableCollection<Experience>();
            _skills = new ObservableCollection<Skill>();

            loadData();
        }

        private void loadData()
        {
            throw new NotImplementedException();
        }
    }
}