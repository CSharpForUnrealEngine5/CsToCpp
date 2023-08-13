namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposureConfigSettings.h")]
public partial class UComposureGameSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>StaticVideoPlateDebugImage</summary>
	public FSoftObjectPath StaticVideoPlateDebugImage;
	///<summary>bSceneCapWarnOfMissingCam</summary>
	public bool bSceneCapWarnOfMissingCam;
	///<summary>FallbackCompositingTexture</summary>
	public FSoftObjectPath FallbackCompositingTexture;
	///<summary>FallbackCompositingTextureObj</summary>
	public UTexture FallbackCompositingTextureObj;
}
