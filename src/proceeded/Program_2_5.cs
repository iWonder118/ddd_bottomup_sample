namespace Proceeded
{
    internal class Program_2_5
    {
        public static void Primary()
        {
            User CreateUser(UserName name)
            {
                var user = new User();
                user.Id = name;
                return user;
            }
        }

        class User
        {
            public UserId Id {get; set;}
            public UserName Name {get; set;}
        }
        class UserName
        {
            private readonly string value;

            public UserName(string value)
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                if (value.Length < 3) throw new ArgumentException("ユーザ名は３文字以上です。", nameof(value));
                this.value = value;
            }
        }

        class UserId
        {
            private readonly string value;

            public UserId(string value)
            {
                if (value == null) throw new ArgumentNullException(nameof(value));

                this.value = value;
            }
        }
    }
}