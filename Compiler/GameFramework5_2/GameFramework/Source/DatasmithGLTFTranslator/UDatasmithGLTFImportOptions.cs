namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithGLTFImportOptions.h")]
public partial class UDatasmithGLTFImportOptions : UDatasmithOptionsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Generate new UV coordinates for lightmapping instead of using the highest index UV set. </summary>
	public bool bGenerateLightmapUVs;
	///<summary>Scale factor used for importing assets, by default: 100, for conversion from meters(glTF) to centimeters(Unreal default).</summary>
	public float ImportScale;
	///<summary>Use animation frame rate from source (as it was exported). If unchecked, animations are resampled with 30 FPS.</summary>
	public bool bAnimationFrameRateFromFile;
}
