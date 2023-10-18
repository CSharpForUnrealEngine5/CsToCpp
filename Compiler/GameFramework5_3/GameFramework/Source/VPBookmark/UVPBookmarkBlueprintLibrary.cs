namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBookmarkBlueprintLibrary.h")]
public partial class UVPBookmarkBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>FindVPBookmark</summary>
	public static UVPBookmark FindVPBookmark(AActor Actor) { return default; }
	///<summary>GetAllVPBookmarkActors</summary>
	public static void GetAllVPBookmarkActors(UObject WorldContextObject,TArray<AActor> OutActors) {}
	///<summary>GetAllVPBookmark</summary>
	public static void GetAllVPBookmark(UObject WorldContextObject,TArray<UVPBookmark> OutBookmarks) {}
	///<summary>CreateVPBookmarkName</summary>
	public static bool CreateVPBookmarkName(AActor Bookmark,string FormatString,string GeneratedNumber,string GeneratedLetter) { return default; }
}
