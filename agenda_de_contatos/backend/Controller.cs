// Criado por Daniela Pompeu de Sousa
using Microsoft.AspNetCore.Mvc;

namespace ContactsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        public static List<Contact> contacts = new();

        [HttpGet]
        public IActionResult Get() => Ok(contacts);

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            contacts.Add(contact);
            return Ok(contact);
        }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
