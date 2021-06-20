namespace OverloadMethod
{
    public static class People
    {
        public static string FullName(string firstName, string middleName)
            => $"{firstName} {middleName}";

        public static string FullName(string firstName, string middleName, string lastName)
            => $"{firstName} {middleName} {lastName}";
    }
}