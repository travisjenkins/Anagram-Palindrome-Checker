# Anagram-Palindrome-Checker

### Anagram:
<ol>
  <li>Take two string inputs, which can be either a word or a phrase, and make all letters lowercase.</li>
  <li>Take both strings and put only the letters (no spaces or punctuation) of each string into separate arrays of letters/characters.</li>
  <li>Check the count of the letters/characters in each array.  If the count is not the same, it is not an anagram, returning false.  If the count is the same, sort the arrays alphabetically.</li>
  <li>Loop through the two alphabetically arranged arrays of letters/characters and compare each letter/character.  If they are all the same, it is an anagram, returning true; otherwise, returning false.</li>
</ol>
    
Pseudo Code:
<ul>
  <li>ISANAGRAM(firstWordOrPhrase, secondWordOrPhrase):</li>
  <ul>
    <li>SET first equal to firstWordOrPhrase (lowercase, no spaces, just letters, as list)</li>
    <li>SET second equal to secondWordOrPhrase (lowercase, no spaces, just letters, as list)</li>
    <li>IF first count equals second count:</li>
    <ul>
      <li>SORT first</li>
      <li>SORT second</li>
      <li>LOOP through first comparing each letter with same index of the second:</li>
      <ul>
        <li>IF all match:</li>
        <ul><li>return True</li></ul>
        <li>Else:</li>
        <ul><li>return False</li></ul>
      </ul>
    </ul>
    <li>ELSE:</li>
    <ul><li>return False</li></ul>
  </ul>
</ul>                   

### Palindrome:
<ol>
  <li>Take two string inputs, which can be either a word or a phrase, and make all letters lowercase.</li>
  <li>Take both strings and put only the letters (no spaces or punctuation) of each string into separate arrays of letters/characters.</li>
  <li>Check the count of the letters/characters in each array.  If the count is not the same, it is not a palindrome, returning false.  If the count is the same, reverse the order of the letters/characters in one array.</li>
  <li>Join each array into a separate string and compare the two strings with each other.  If they are the same, it is a palindrome, returning true; otherwise, returning false.</li>
</ol> 
 
Pseudo Code:
<ul>
  <li>ISPALINDROME(firstWordOrPhrase, secondWordOrPhrase):</li>
  <ul>
    <li>SET first equal to firstWordOrPhrase (lowercase, no spaces, just letters, as list)</li>
    <li>SET second equal to secondWordOrPhrase (lowercase, no spaces, just letters, as list)</li>
    <li>IF first count equals second count:</li>
    <ul>
      <li>REVERSE second order</li>
      <li>JOIN first and second as strings</li>
      <li>IF first equals second:</li>
      <ul><li>return True</li></ul>
      <li>ELSE:</li>
      <ul><li>return False</li></ul>
    </ul>
    <li>ELSE:</li>
    <ul><li>return False</li></ul>
  </ul>
</ul>
 
### Big-O Time Complexity:  
O (N log (N))
