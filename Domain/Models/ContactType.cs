using System.Collections.Generic;

namespace Domain.Models
{
    public class ContactType
    {
        public int ContactTypeId { get; set; }
        public string ContactTypeName { get; set; }

        public virtual List<Contact> Contacts { get; set; }
    }
}