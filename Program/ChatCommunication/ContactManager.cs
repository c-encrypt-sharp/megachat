using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class ContactManager
    {
        public ContactManager() { }

        /// <summary>
        /// Adds the specified account
        /// </summary>
        /// <param name="contact">selected account</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new ContactManager().AddContact(new Contact()
        /// {
        ///     para1 = value;
        ///     para2 = value;
        ///     ...
        /// });
        /// </code>
        /// 
        ///     OR
        /// 
        /// <code>
        /// var contact = new Contact()
        /// {
        ///     para1 = value;
        ///     para2 = value;
        ///     ...
        /// };
        /// new ContactManager().AddContact(contact);
        /// </code>
        /// </example>
        public void AddContact(Contact contact) { }

        /// <summary>
        /// Delete the specified account
        /// </summary>
        /// <param name="contact">selected account</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new ContactManager().RemoveContact(new Contact()
        /// {
        ///     para1 = value;
        ///     para2 = value;
        ///     ...
        /// });
        /// </code>
        /// 
        ///     OR
        /// 
        /// <code>
        /// var contact = new Contact()
        /// {
        ///     para1 = value;
        ///     para2 = value;
        ///     ...
        /// };
        /// new ContactManager().RemoveContact(contact);
        /// </code>
        public void RemoveContact(Contact contact) { }
    }
}
