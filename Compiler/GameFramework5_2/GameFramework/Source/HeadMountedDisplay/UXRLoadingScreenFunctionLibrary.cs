#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRLoadingScreenFunctionLibrary.h")]
///<summary>XR Loading Screen Function Library</summary>
public partial class UXRLoadingScreenFunctionLibrary : UBlueprintFunctionLibrary {
// XRLoadingScreenFunctionLibrary
	public static void SetLoadingScreen(UTexture Texture,FVector2D Scale/*=new FVector2D(1.0f,1.0f)*/,FVector Offset/*=FVector.ZeroVector*/,bool bShowLoadingMovie/*=false*/,bool bShowOnSet/*=false*/) {}
	public static void ClearLoadingScreenSplashes() {}
	public static void AddLoadingScreenSplash(UTexture Texture,FVector Translation,FRotator Rotation,FVector2D Size/*=new FVector2D(1.0f,1.0f)*/,FRotator DeltaRotation/*=FRotator.ZeroRotator*/,bool bClearBeforeAdd/*=false*/) {}
	public static void ShowLoadingScreen() {}
	public static void HideLoadingScreen() {}
}
