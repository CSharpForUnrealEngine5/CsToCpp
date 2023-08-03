#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>XR Loading Screen Function Library</summary>
[CppInclude("XRLoadingScreenFunctionLibrary.h")]
public partial class UXRLoadingScreenFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>SetLoadingScreen</summary>
	public static void SetLoadingScreen(UTexture Texture,FVector2D Scale/*=new FVector2D(1.0f,1.0f)*/,FVector Offset/*=FVector.ZeroVector*/,bool bShowLoadingMovie/*=false*/,bool bShowOnSet/*=false*/) {}
	///<summary>ClearLoadingScreenSplashes</summary>
	public static void ClearLoadingScreenSplashes() {}
	///<summary>Adds a splash element to the loading screen.</summary>
	public static void AddLoadingScreenSplash(UTexture Texture,FVector Translation,FRotator Rotation,FVector2D Size/*=new FVector2D(1.0f,1.0f)*/,FRotator DeltaRotation/*=FRotator.ZeroRotator*/,bool bClearBeforeAdd/*=false*/) {}
	///<summary>Show the loading screen and override the VR display</summary>
	public static void ShowLoadingScreen() {}
	///<summary>Hide the splash screen and return to normal display.</summary>
	public static void HideLoadingScreen() {}
}
