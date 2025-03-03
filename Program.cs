Random rnd = new Random();
Console.WriteLine("Password Generator");
Console.WriteLine("Enter Length of Password");
int lengthOfPassword = Convert.ToInt32(Console.ReadLine());

string upperAlphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string lowerAlphabets = "abcdefghijklmnopqrstuvwxyz";
string numArray = "0123456789";
string specialChar = "~`!@#$%^&*()_+[]{};':<>\",./?";

char[] generatedPassword = new char[lengthOfPassword];
int charRandom = 0;



//1 = upperAlphbet //2 = lowerAlphabet // 3 = numArray // 4 = specialChar
for (int i = 0; i < generatedPassword.Length; i++)
{
    int typeRandom = rnd.Next(1, 4); //for generating different type of "array"/string to use.
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

Console.Write("Generated Password: ");
foreach(char c in generatedPassword)
{
    Console.Write($"{c}");
}
