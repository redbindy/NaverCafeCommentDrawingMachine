using System.Diagnostics;

namespace DrawMachine
{
    public struct User
    {
        public string Name { get; }
        public string Comment { get; }

        public User(string name, string comment)
        {
            Debug.Assert(name != null && comment != null);

            Name = name;
            Comment = comment;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is User))
            {
                return false;
            }

            return Name == ((User) obj).Name;
        }
    }
}
