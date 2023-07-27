#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AppleImageUtilsBlueprintProxy.h")]
public partial class UAppleImageUtilsBaseAsyncTaskBlueprintProxy : UObject {
// AppleImageUtilsBaseAsyncTaskBlueprintProxy
	public FAppleImageConversionDelegate OnSuccess;
	public FAppleImageConversionDelegate OnFailure;
	public static UAppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToJPEG(UTexture SourceImage,int Quality/*=85*/,bool bWantColor/*=true*/,bool bUseGpu/*=true*/,float Scale/*=1.0f*/,ETextureRotationDirection Rotate/*=ETextureRotationDirection.None*/) { return default; }
	public static UAppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToHEIF(UTexture SourceImage,int Quality/*=85*/,bool bWantColor/*=true*/,bool bUseGpu/*=true*/,float Scale/*=1.0f*/,ETextureRotationDirection Rotate/*=ETextureRotationDirection.None*/) { return default; }
	public static UAppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToTIFF(UTexture SourceImage,bool bWantColor/*=true*/,bool bUseGpu/*=true*/,float Scale/*=1.0f*/,ETextureRotationDirection Rotate/*=ETextureRotationDirection.None*/) { return default; }
	public static UAppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToPNG(UTexture SourceImage,bool bWantColor/*=true*/,bool bUseGpu/*=true*/,float Scale/*=1.0f*/,ETextureRotationDirection Rotate/*=ETextureRotationDirection.None*/) { return default; }
	public FAppleImageUtilsImageConversionResult ConversionResult;
}
