namespace Proceeded
{
    internal class Program_3_1
    {
        public static void Primary()
        {
            User userA = new User(new UserId("111"), "taro");
            User userB = new User(new UserId("112"), "jiro");
            Check(userA, userB);
            Check(userA, userA);
        }

        static void Check(User leftUser, User rightUser)
        {
            if (leftUser.Equals(rightUser))
            {
                Console.WriteLine("同一のユーザです");
            }
            else
            {
                Console.WriteLine("別のユーザです");
            }
        }

        class UserId
        {
            private string value;

            public UserId(string value)
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                this.value = value;
            }
        }

        class User : IEquatable<User>
        {
            private readonly UserId id;
            private string name;
            public User(UserId id, string name)
            {
                if (id == null) throw new ArgumentNullException(nameof(id));
                if (name == null) throw new ArgumentNullException(nameof(name));
                this.id = id;
                ChangeUserName(name);
                
            }

            public void ChangeUserName(string name)
            {
                if (name == null) throw new ArgumentNullException(nameof(name));
                if (name.Length < 3) throw new ArgumentException("ユーザ名は３文字以上です。", nameof(name));
                this.name = name;
            }

            public bool Equals(User other)
            {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Equals(id, other.id);
            }
            public override bool Equals(Object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((User) obj);
            }

            public override int GetHashCode()
            {
                return (id != null ? id.GetHashCode() : 0);
            }
        }
    }
}