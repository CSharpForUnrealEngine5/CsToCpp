#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/StereoLayerFunctionLibrary.h")]
///<summary>StereoLayer Extensions Function Library</summary>
public partial class UStereoLayerFunctionLibrary : UBlueprintFunctionLibrary {
// StereoLayerFunctionLibrary
	public static void SetSplashScreen(UTexture Texture,FVector2D Scale/*=new FVector2D(1.0f,1.0f)*/,FVector Offset/*=new FVector(0.0f,0.0f,0.0f)*/,bool bShowLoadingMovie/*=false*/,bool bShowOnSet/*=false*/) {}
	public static void ShowSplashScreen() {}
	public static void HideSplashScreen() {}
	public static void EnableAutoLoadingSplashScreen(bool InAutoShowEnabled) {}
}
