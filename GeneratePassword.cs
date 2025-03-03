class GeneratePassword
{
    Random rnd = new Random();
    private int lengthOfPw;
    private string upperAlphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private string lowerAlphabets = "abcdefghijklmnopqrstuvwxyz";
    private string numArray = "0123456789";
    private string specialChar = "~`!@#$%^&*()_+[]{};':<>\",./?";
    private char[] password;
    public GeneratePassword()
    {
        Console.WriteLine("Password Generator");
        Console.Write("Enter Length of Password: ");
        lengthOfPw = Convert.ToInt32(Console.ReadLine());
        PrintPassword(password = Generator(lengthOfPw));
    }
    

    private char[] Generator(int passwordLength)
    {
        char[] generatedPassword = new char[passwordLength];
        int charRandom = 0; //to store a random generating value for selecting types of character 
        //1 = upperAlphbet //2 = lowerAlphabet // 3 = numArray // 4 = specialChar

        for (int i = 0; i < generatedPassword.Length; i++)
        {
            int typeRandom = rnd.Next(1, 5); //for generating different type of "array"/string to use.
            switch (typeRandom)
            {
                case 1:
                    charRandom = rnd.Next(0, upperAlphabets.Length - 1);
                    generatedPassword[i] = upperAlphabets[charRandom];
                    break;

                case 2:
                    charRandom = rnd.Next(0, lowerAlphabets.Length - 1);
                    generatedPassword[i] = lowerAlphabets[charRandom];
                    break;

                case 3:
                    charRandom = rnd.Next(0, numArray.Length - 1);
                    generatedPassword[i] = numArray[charRandom];
                    break;

                case 4:
                    charRandom = rnd.Next(0, specialChar.Length - 1);
                    generatedPassword[i] = specialChar[charRandom];
                    break;
            }
        }
        return generatedPassword; 
    }
    private static void PrintPassword(char[] passArray)
    {
        Console.Write("Generated Password: ");
        foreach (char c in passArray)
        {
            Console.Write($"{c}");
        }
    }

    
}