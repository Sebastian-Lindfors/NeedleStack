namespace needlestack.core;

public class Class1
{

    public static int NeedleStack(string haystack, string needle)
    {
        // We loop through the haystack string.
        for (int i = 0; i < haystack.Length; i++)
        {
            // If needle is out of bounds, then the needle substring does not exist in the haystack string.
            // Hence, we return -1.
            if (i + needle.Length > haystack.Length) return -1;

            // If the substring starting at our current index with the length of the needle string
            // is equal to the needle string, we've found the first occurence.
            // Hence, we return the current index.
            if (needle == haystack.Substring(i, needle.Length)) return i;
        }

        // If the loop finishes without finding an occurence of the needle string in the haystack string, 
        // we return -1.
        return -1;
    }
}
