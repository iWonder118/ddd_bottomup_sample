using System.Runtime.InteropServices;

namespace Proceeded
{
    internal class Program_4_2
    {
        public static void Primary()
        {
            var userService = new UserService();

            var userId = new UserId("id");
            var userName = new UserName("iwonder");
            var user = new User(userId, userName);

            // 重複確認用インスタンスに問い合わせ
            var duplicateCheckResult = userService.Exists(user);
            Console.WriteLine(duplicateCheckResult);
        }

        class UserService
        {
            public bool Exists(User user)
            {
                // 重複を確認するコード
                return true;
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

        class User
        {
            private readonly UserId id;
            private UserName name;
            public User(UserId id, UserName name)
            {
                if (id == null) throw new ArgumentNullException(nameof(id));
                if (name == null) throw new ArgumentNullException(nameof(name));
                this.id = id;
                this.name = name;
                
            }
        }
    }
}