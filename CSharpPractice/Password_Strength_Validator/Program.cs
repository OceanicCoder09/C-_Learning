using System;

class Program
{
    public static bool checkLength(string password)
    {
        if(password.Length >= 8)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool checkUpperCase(string password)
    {
        for(int i=0; i<password.Length; i++)
        {
            char ch = password[i];
            if((int)ch >= 65 && (int)ch <= 90)
            {
                return true;
            }
        }
        return false;
    }

    public static bool checkLowerCase(string password)
    {
        for(int i=0; i<password.Length; i++)
        {
            char ch = password[i];
            if((int)ch >= 97 && (int)ch <= 122)
            {
                return true;
            }
        }
        return false;
    }
    public static bool checkDigit(string password)
    {
        for(int i = 0; i<password.Length; i++)
        {
            char ch = password[i];
            if(char.IsDigit(ch))
            {
                return true;
            }
        }
        return false;
    }
    public static bool checkOneSpecialCharacter(string passward)
    {
        HashSet<char> specialCharacters = new HashSet<char>() { '!', '@', '#', '$', '%', '^', '&', '*' };

        for(int i=0; i<passward.Length; i++)
        {
            char ch = passward[i];
            if(specialCharacters.Contains(ch))
            {
                return true;
            }
        }
        return false;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your password: ");
        string password = Console.ReadLine();

        if(checkLength(password) && checkUpperCase(password) && checkLowerCase(password) && checkDigit(password) && checkOneSpecialCharacter(password))
        {
            Console.WriteLine("Password is strong.");
        }
        else
        {
            Console.WriteLine("Password is weak.");
        }
    }
}
