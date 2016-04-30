using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain.Models
{
    public class ContactType
    {
        public int ContactTypeId { get; set; }
        public string ContactTypeName { get; set; }

        public virtual ObservableCollection<Contact> Contacts { get; set; }
    }
}