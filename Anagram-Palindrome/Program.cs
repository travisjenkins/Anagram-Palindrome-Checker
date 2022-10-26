using Anagram_Palindrome;

while (true)
{
    Console.WriteLine("\nWelcome to the Anagram & Palindrome Checker!");

    Console.Write("\nPlease enter the first word or phrase:  ");
    string? firstWordOrPhrase = Console.ReadLine();

    Console.Write("\nPlease enter the second word or phrase:  ");
    string? secondWordOrPhrase = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(firstWordOrPhrase) && !string.IsNullOrWhiteSpace(secondWordOrPhrase))
    {
        string result = string.Empty;
        HelperMethods helper = new HelperMethods();
        if (helper.IsAnagram(firstWordOrPhrase, secondWordOrPhrase))
        {
            result = "RESULTS:  The words/phrases are Anagrams";
        }
        if (helper.IsPalindrome(firstWordOrPhrase, secondWordOrPhrase))
        {
            if (string.IsNullOrEmpty(result))
            {
                result = "RESULTS:  The words/phrases are Palindromes";
            }
            else
            {
                result += " and Palindromes";
            }
        }
        if (string.IsNullOrEmpty(result))
        {
            result = "RESULTS:  The words/phrases were neither Anagrams nor Palindromes";
        }
        Console.WriteLine($"\n{result}");

        Console.Write("\nWould you like to try again?  (y or n):  ");
        string? userContinue = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(userContinue))
        {
            Console.WriteLine("\nThank you for using the Anagram & Palindrome Checker!\n");
            break;
        }
        if (userContinue.ToLower() != "y")
        {
            Console.WriteLine("\nThank you for using the Anagram & Palindrome Checker!\n");
            break;
        }
    }
    else
    {
        Console.WriteLine("\nERROR:  You must enter the first and second words/phrases to peform these checks.");
    }
}