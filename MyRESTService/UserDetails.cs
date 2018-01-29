using System.Runtime.Serialization;

namespace MyRESTService
{
    public class UserDetails
    {
        string username = string.Empty;
        string password = string.Empty;
        string country = string.Empty;
        string email = string.Empty;

        [DataMember]
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        [DataMember]
        public string Password

        {
            get { return password; }
            set { password = value; }
        }

        [DataMember]
        public string Country

        {
            get { return country; }
            set { country = value; }
        }

        [DataMember]
        public string Email

        {
            get { return email; }
            set { email = value; }
        }
    }
}