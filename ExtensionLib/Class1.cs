namespace ExtensionLib{

public static class Class1
{

    public static int WordCount1(this string str)
    {
        return str.Split(new char[] { ' ', '.', '?' },StringSplitOptions.RemoveEmptyEntries).Length;

    }

}
}