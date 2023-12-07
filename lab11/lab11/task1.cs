class StringReplacer
{
    public static string ReplaceOnesAndZeros(string input, int startPosition)
    {
        char[] charArray = input.ToCharArray();

        for (int i = startPosition; i < charArray.Length; i++)
        {
            if (charArray[i] == '0')
                charArray[i] = '1';
            else if (charArray[i] == '1')
                charArray[i] = '0';
        }

        return new string(charArray);
    }
}