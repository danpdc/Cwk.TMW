using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Common.Types
{
    public record Name
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Initials { get { return GetInitials(); } }
        public string FullName { get { return GetFullName(); } }

        private string GetInitials()
        {
            var sb = new StringBuilder();
            sb.Append(FirstName[0].ToString().ToUpperInvariant());
            sb.Append(LastName[0].ToString().ToUpperInvariant());

            return sb.ToString();
        }

        private string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
