namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Manages gradient LUT textures for registered actors and assigns them to the corresponding materials on the actor</summary>
[CppInclude("Curves/CurveLinearColorAtlas.h")]
public partial class UCurveLinearColorAtlas : UTexture2D {
	public static UClass StaticClass() {return default;}
	///<summary>GetCurvePosition</summary>
	public bool GetCurvePosition(UCurveLinearColor InCurve,float Position) { return default; }
	///<summary>bIsDirty</summary>
	public bool bIsDirty;
	///<summary>TextureSize</summary>
	public uint TextureSize;
	///<summary>Set texture height equal to texture width.</summary>
	public bool bSquareResolution;
	///<summary>TextureHeight</summary>
	public uint TextureHeight;
	///<summary>Height of the lookup textures</summary>
	public TArray<UCurveLinearColor> GradientCurves;
	///<summary>Disable all color adjustments to preserve negative values in curves. Color adjustments clamp to 0 when enabled.</summary>
	public bool bDisableAllAdjustments;
	///<summary>bHasCachedColorAdjustments</summary>
	public bool bHasCachedColorAdjustments;
	///<summary>CachedColorAdjustments</summary>
	public FCurveAtlasColorAdjustments CachedColorAdjustments;
}
