using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    // Encodes a list of strings to a single string.
    public string Encode(List<string> strs)
    {
        // Concatenate all the strings with their length and '#' delimiter.
        return string.Concat(strs.Select(s => $"{s.Length}#{s}"));
    }

    // Decodes a single string to a list of strings.
    public List<string> Decode(string s)
    {
        var result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            // Find the index of the next '#' character.
            int j = i;
            while (j < s.Length && s[j] != '#')
            {
                j++;
            }

            // Parse the length of the next string.
            if (j < s.Length)
            {
                int length;
                if (int.TryParse(s.Substring(i, j - i), out length))
                {
                    // Move past the '#' character.
                    j++;

                    // Extract the substring of the specified length.
                    string str = s.Substring(j, length);
                    result.Add(str);

                    // Move to the next encoded string.
                    i = j + length;
                }
                else
                {
                    throw new FormatException("Encoded string is not in the correct format.");
                }
            }
            else
            {
                throw new FormatException("Encoded string is not in the correct format.");
            }
        }

        return result;
    }
}
