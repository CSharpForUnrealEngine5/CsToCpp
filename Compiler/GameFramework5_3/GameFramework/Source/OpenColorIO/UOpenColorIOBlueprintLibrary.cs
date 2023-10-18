namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenColorIOBlueprintLibrary.h")]
public partial class UOpenColorIOBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Applies a rendering pass of the color transform described in the settings</summary>
	public static bool ApplyColorSpaceTransform(UObject WorldContextObject,FOpenColorIOColorConversionSettings ConversionSettings,UTexture InputTexture,UTextureRenderTarget2D OutputRenderTarget) { return default; }
}
