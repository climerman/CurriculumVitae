using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string ContactValue { get; set; }

        [ForeignKey(nameof(ContactType))]
        public int ContactTypeId { get; set; }
        public ContactType ContactType { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}