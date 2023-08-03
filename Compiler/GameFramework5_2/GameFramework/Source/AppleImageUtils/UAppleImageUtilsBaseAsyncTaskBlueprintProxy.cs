#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AppleImageUtilsBlueprintProxy.h")]
public partial class UAppleImageUtilsBaseAsyncTaskBlueprintProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>OnSuccess</summary>
	public FAppleImageConversionDelegate OnSuccess;
	///<summary>OnFailure</summary>
	public FAppleImageConversionDelegate OnFailure;
	///<summary>Converts a image to an array of JPEG data in a background task</summary>
	public static UAppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToJPEG(UTexture SourceImage,int Quality/*=85*/,bool bWantColor/*=true*/,bool bUseGpu/*=true*/,float Scale/*=1.0f*/,ETextureRotationDirection Rotate/*=ETextureRotationDirection.None*/) { return default; }
	///<summary>Converts a image to an array of HEIF data in a background task</summary>
	public static UAppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToHEIF(UTexture SourceImage,int Quality/*=85*/,bool bWantColor/*=true*/,bool bUseGpu/*=true*/,float Scale/*=1.0f*/,ETextureRotationDirection Rotate/*=ETextureRotationDirection.None*/) { return default; }
	///<summary>Converts a image to an array of TIFF data in a background task</summary>
	public static UAppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToTIFF(UTexture SourceImage,bool bWantColor/*=true*/,bool bUseGpu/*=true*/,float Scale/*=1.0f*/,ETextureRotationDirection Rotate/*=ETextureRotationDirection.None*/) { return default; }
	///<summary>Converts a image to an array of TIFF data in a background task</summary>
	public static UAppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToPNG(UTexture SourceImage,bool bWantColor/*=true*/,bool bUseGpu/*=true*/,float Scale/*=1.0f*/,ETextureRotationDirection Rotate/*=ETextureRotationDirection.None*/) { return default; }
	///<summary>ConversionResult</summary>
	public FAppleImageUtilsImageConversionResult ConversionResult;
}
