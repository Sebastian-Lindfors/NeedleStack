namespace needlestack.core;

public class Class1
{

    public static int NeedleStack(string haystack, string needle)
    {
        for (int i = 0; i < haystack.Length; i++)
        {
            if (i + needle.Length > haystack.Length) return -1;

            if (needle == haystack.Substring(i, needle.Length)) return i;
        }

        return -1;
    }
}
