using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using Domain.Models;

namespace BLL
{
    public interface IPersonService
    {
        List<Person> LoadPersons();
    }
}