#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;

public static class StringExtensions
{
    public static void Empty(this string String, int Slack=0) { }
    public static bool IsEmpty(this string String) { return false; }

    public static void InsertAt(this string String, int Index, string Text) { }
    public static void RemoveAt(this string String, int Index, int Count, bool bAllowShrinking = true) { }
    public static int Len(this string String) { return 0; }
    public static string Left(this string String, int Len) { return ""; }
    public static string Right(this string String, int Len) { return ""; }
    public static string Mid(this string String, int Start, int Len) { return ""; }
    public static string Mid(this string String, int Start) { return ""; }

    public static int Find(this string String, string SubStr,
        ESearchCase SearchCase = ESearchCase.IgnoreCase,
        ESearchDir SearchDir = ESearchDir.FromStart, int StartPosition = 0)
    { return 0; }
    public static bool Contains(this string String, string SubStr,
        ESearchCase SearchCase = ESearchCase.IgnoreCase,
        ESearchDir SearchDir = ESearchDir.FromStart)
    { return false; }


}
