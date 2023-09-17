using System.Collections.Generic;
using System.Diagnostics;

namespace NaverCafeCommentDrawingMachine
{
    public class User
    {
        public string Name { get; private set; }
        public string Comment { get; private set; }
        public string PrizeOrNull { get; private set; }

        public User (string name, string comment, string prize)
        {
            Debug.Assert(name != null && comment != null);

            Name = name;
            Comment = comment;
            PrizeOrNull = prize;
        }

        public User(string name, string comment)
            : this (name, comment, null)
        {

        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            User other = obj as User;

            if (other == null)
            {
                return false;
            }

            return Name == other.Name;
        }
    }
}
