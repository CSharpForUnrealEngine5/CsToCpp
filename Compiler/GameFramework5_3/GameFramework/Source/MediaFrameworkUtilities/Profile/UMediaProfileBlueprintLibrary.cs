namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Profile/MediaProfileBlueprintLibrary.h")]
public partial class UMediaProfileBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetMediaProfile</summary>
	public static UMediaProfile GetMediaProfile() { return default; }
	///<summary>SetMediaProfile</summary>
	public static void SetMediaProfile(UMediaProfile MediaProfile) {}
	///<summary>GetAllMediaSourceProxy</summary>
	public static TArray<UProxyMediaSource> GetAllMediaSourceProxy() { return default; }
	///<summary>GetAllMediaOutputProxy</summary>
	public static TArray<UProxyMediaOutput> GetAllMediaOutputProxy() { return default; }
}
