#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>StereoLayer Extensions Function Library</summary>
[CppInclude("Kismet/StereoLayerFunctionLibrary.h")]
public partial class UStereoLayerFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Set splash screen attributes</summary>
	public static void SetSplashScreen(UTexture Texture,FVector2D Scale/*=new FVector2D(1.0f,1.0f)*/,FVector Offset/*=new FVector(0.0f,0.0f,0.0f)*/,bool bShowLoadingMovie/*=false*/,bool bShowOnSet/*=false*/) {}
	///<summary>Show the splash screen and override the VR display</summary>
	public static void ShowSplashScreen() {}
	///<summary>Hide the splash screen and return to normal display.</summary>
	public static void HideSplashScreen() {}
	///<summary>Enables/disables splash screen to be automatically shown when LoadMap is called.</summary>
	public static void EnableAutoLoadingSplashScreen(bool InAutoShowEnabled) {}
}
