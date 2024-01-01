namespace Proceeded
{
    internal class Program_2_5
    {
        public static void Primary()
        {
            var userName = "me";

            if (userName.Length >= 3)
            {
                // 正常な値
            }
            else
            {
                throw new Exception("異常な値です");
            }
        }
    }
}