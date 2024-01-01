namespace Proceeded
{
    internal class Program_3_1
    {
        public static void Primary()
        {
            
        }

        class User
        {
            private string name;
            public User(string name)
            {
                if (name == null) throw new ArgumentNullException(nameof(name));
                if (name.Length < 3) throw new ArgumentException("ユーザ名は３文字以上です。", nameof(name));
                this.name = name;
            }
        
        }
    }
}