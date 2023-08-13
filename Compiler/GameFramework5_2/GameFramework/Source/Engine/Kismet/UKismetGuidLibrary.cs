namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetGuidLibrary.h")]
public partial class UKismetGuidLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns true if the values are equal (A == B)</summary>
	public static bool EqualEqual_GuidGuid(FGuid A,FGuid B) { return default; }
	///<summary>Returns true if the values are not equal (A != B)</summary>
	public static bool NotEqual_GuidGuid(FGuid A,FGuid B) { return default; }
	///<summary>Checks whether the given GUID is valid</summary>
	public static bool IsValid_Guid(FGuid InGuid) { return default; }
	///<summary>Invalidates the given GUID</summary>
	public static void Invalidate_Guid(FGuid InGuid) {}
	///<summary>Returns a new unique GUID</summary>
	public static FGuid NewGuid() { return default; }
	///<summary>Converts a GUID value to a string, in the form &#39;A-B-C-D&#39;</summary>
	public static string Conv_GuidToString(FGuid InGuid) { return default; }
	///<summary>Converts a String of format EGuidFormats to a Guid. Returns Guid OutGuid, Returns bool Success</summary>
	public static void Parse_StringToGuid(string GuidString,FGuid OutGuid,bool Success) {}
}
