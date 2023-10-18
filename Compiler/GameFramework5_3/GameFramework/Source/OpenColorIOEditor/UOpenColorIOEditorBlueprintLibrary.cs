namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenColorIOEditorBlueprintLibrary.h")]
public partial class UOpenColorIOEditorBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Set the active editor viewport&#39;s display configuration color transform .</summary>
	public static void SetActiveViewportConfiguration(FOpenColorIODisplayConfiguration InConfiguration) {}
	///<summary>Apply a color space transform to a texture asset.</summary>
	public static bool ApplyColorSpaceTransformToTexture(FOpenColorIOColorConversionSettings ConversionSettings,UTexture InOutTexture) { return default; }
	///<summary>Apply a color space transform with a target compression setting to a texture asset.</summary>
	public static bool ApplyColorSpaceTransformToTextureCompressed(FOpenColorIOColorConversionSettings ConversionSettings,TextureCompressionSettings TargetCompression,UTexture InOutTexture) { return default; }
}
