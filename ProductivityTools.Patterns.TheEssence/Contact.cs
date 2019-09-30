using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.TheEssence
{
    public class Contact
    {
        private string mPostalAddress = string.Empty;   // Optional address value.
        private string mPhoneNumber = string.Empty;     // Optional phone number value
        private readonly string mFirstName = string.Empty;       // Copied from essence
        private readonly string mLastName = string.Empty;        // Copied from essence

        public string LastName => mLastName;
        public string FirstName => mFirstName;

        public string PostalAddress
        {
            get
            {
                return mPostalAddress;
            }
            set
            {
                if (mPostalAddress != value)
                    mPostalAddress = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                if (mPhoneNumber != value)
                    mPhoneNumber = value;
            }
        }

        public class ContactEssence
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public ContactEssence() { }

            public Contact CreateContact()
            {
                if (this.Validate() == true)
                    return new Contact(this);
                return null;
            }

            private bool Validate()
            {
                if (FirstName ==null || FirstName.Length == 0) return false;
                if (LastName == null || LastName?.Length == 0)return false;
                return true;
            }
        }

        // Private constructor can only be accessed by internal classes
        private Contact(Contact.ContactEssence xEssence)
        {
            // Copy required, immutable properties from essence
            mFirstName = xEssence.FirstName;
            mLastName = xEssence.LastName;
        }

        // We make the default constructor private and mark it as obsolete.
        [System.Obsolete("This constructor is obsolete -- use the ContactEssence class to create Contacts", true)]
        private Contact()
        {
        }

        public override string ToString()
        {
            System.Text.StringBuilder outString = new System.Text.StringBuilder();
            System.IFormatProvider format = System.Globalization.CultureInfo.CurrentUICulture;

            outString.AppendFormat(format, "Name : {0} {1}\n", this.FirstName, this.LastName);
            outString.AppendFormat(format, "Phone: {0}\n", this.PhoneNumber);
            outString.AppendFormat(format, "Address: {0}\n", this.PostalAddress);

            return outString.ToString();
        }
    }
}
