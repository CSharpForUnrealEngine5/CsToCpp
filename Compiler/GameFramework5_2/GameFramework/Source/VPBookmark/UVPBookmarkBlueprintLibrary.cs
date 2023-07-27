#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBookmarkBlueprintLibrary.h")]
public partial class UVPBookmarkBlueprintLibrary : UBlueprintFunctionLibrary {
// VPBookmarkBlueprintLibrary
	public static UVPBookmark FindVPBookmark(AActor Actor) { return default; }
	public static void GetAllVPBookmarkActors(UObject WorldContextObject,TArray<AActor> OutActors) {}
	public static void GetAllVPBookmark(UObject WorldContextObject,TArray<UVPBookmark> OutBookmarks) {}
	public static bool CreateVPBookmarkName(AActor Bookmark,string FormatString,string GeneratedNumber,string GeneratedLetter) { return default; }
}
