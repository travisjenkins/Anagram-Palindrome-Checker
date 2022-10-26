# Anagram-Palindrome-Checker

Anagram:
    1. Take two string inputs, which can be either a word or a phrase, and make all letters lowercase.
    2. Take both strings and put only the letters (no spaces or punctuation) of each string into separate arrays of letters/characters.
    3. Check the count of the letters/characters in each array.  If the count is not the same, it is not an anagram, returning false.  If the count is the        same, sort the arrays alphabetically.
    4. Loop through the two alphabetically arranged arrays of letters/characters and compare each letter/character.  If they are all the same, it is an            anagram, returning true; otherwise, returning false.
 
Pseudo Code:
    ISANAGRAM(firstWordOrPhrase, secondWordOrPhrase):
        SET first equal to firstWordOrPhrase (lowercase, no spaces, just letters, as list)
        SET second equal to secondWordOrPhrase (lowercase, no spaces, just letters, as list)
        IF first count equals second count:
            SORT first
            SORT second
            LOOP through first comparing each letter with same index of the second:
                IF all match:
                    return True
                Else:
                    return False
        ELSE:
            return False
                        

Palindrome:
    1. Take two string inputs, which can be either a word or a phrase, and make all letters lowercase.
    2. Take both strings and put only the letters (no spaces or punctuation) of each string into separate arrays of letters/characters.
    3. Check the count of the letters/characters in each array.  If the count is not the same, it is not a palindrome, returning false.  If the count is          the same, reverse the order of the letters/characters in one array.
    4. Join each array into a separate string and compare the two strings with each other.  If they are the same, it is a palindrome, returning true;              otherwise, returning false.
 
Pseudo Code:
ISPALINDROME(firstWordOrPhrase, secondWordOrPhrase):
    SET first equal to firstWordOrPhrase (lowercase, no spaces, just letters, as list)
    SET second equal to secondWordOrPhrase (lowercase, no spaces, just letters, as list)
    IF first count equals second count:
        REVERSE second order
        JOIN first and second as strings
        IF first equals second:
            return True
        ELSE:
            return False
 
Big-O Time Complexity:  O (N log (N))
