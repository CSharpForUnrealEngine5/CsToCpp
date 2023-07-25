#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AppleImageUtilsBlueprintProxy.h")]
public partial class UAppleImageUtilsBaseAsyncTaskBlueprintProxy : UObject {
// AppleImageUtilsBaseAsyncTaskBlueprintProxy
	public FAppleImageConversionDelegate OnSuccess;
	public FAppleImageConversionDelegate OnFailure;
	public UObject CreateProxyObjectForConvertToJPEG(UObject SourceImage,int Quality/*=85*/,bool bWantColor/*=true*/,bool bUseGpu/*=true*/,float Scale/*=1.0f*/,ETextureRotationDirection Rotate/*=ETextureRotationDirection.None*/) { return default; }
	public UObject CreateProxyObjectForConvertToHEIF(UObject SourceImage,int Quality/*=85*/,bool bWantColor/*=true*/,bool bUseGpu/*=true*/,float Scale/*=1.0f*/,ETextureRotationDirection Rotate/*=ETextureRotationDirection.None*/) { return default; }
	public UObject CreateProxyObjectForConvertToTIFF(UObject SourceImage,bool bWantColor/*=true*/,bool bUseGpu/*=true*/,float Scale/*=1.0f*/,ETextureRotationDirection Rotate/*=ETextureRotationDirection.None*/) { return default; }
	public UObject CreateProxyObjectForConvertToPNG(UObject SourceImage,bool bWantColor/*=true*/,bool bUseGpu/*=true*/,float Scale/*=1.0f*/,ETextureRotationDirection Rotate/*=ETextureRotationDirection.None*/) { return default; }
	public FAppleImageUtilsImageConversionResult ConversionResult;
}
