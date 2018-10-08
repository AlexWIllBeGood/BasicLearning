using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebApi20181008.Models
{
    public interface IContactRepository
    {
        IEnumerable GetAllContacts();
        Contact GetContact(string id);
        Contact AddContact(Contact item);
        bool RemoveContact(string id);
        bool UpdateContact(string id, Contact item);
    }
}
