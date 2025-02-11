public class Solution {
    public bool DetectCapitalUse(string word)
    {
        int upperCount = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (char.IsUpper(word[i])) upperCount++;
        }

        return upperCount == 0 ||
            upperCount == word.Length ||
            (upperCount == 1 && char.IsUpper(word[0]));
    }
}