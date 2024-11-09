bool IsPalindrome(string input)
{
    int start = 0;
    int end = input.Length - 1;

    while (start < end)
    {
        while (start < end && !char.IsLetterOrDigit(input[start]))
            start++;

        while (start < end && !char.IsLetterOrDigit(input[end]))
            end--;

        if (char.ToLower(input[start]) != char.ToLower(input[end]))
            return false;

        start++;
        end--;
    }

    return true;
}

void Check(string s, bool shouldBePalindrome)
{
    Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
}


Check("abcba", true);
Check("abcde", false);
Check("Mr owl ate my metal worm", true);
Check("Never Odd Or Even", true);
Check("Never Even Or Odd", false);

/*
 * OUTPUT:
pass
pass
pass
pass
pass
 * 
 */