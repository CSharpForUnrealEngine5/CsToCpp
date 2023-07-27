#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Curves/CurveLinearColorAtlas.h")]
///<summary>Manages gradient LUT textures for registered actors and assigns them to the corresponding materials on the actor</summary>
public partial class UCurveLinearColorAtlas : UTexture2D {
// CurveLinearColorAtlas
	public  bool GetCurvePosition(UCurveLinearColor InCurve,float Position) { return default; }
	public bool bIsDirty;
	public uint TextureSize;
	public bool bSquareResolution;
	public uint TextureHeight;
	public TArray<UCurveLinearColor> GradientCurves;
	public bool bDisableAllAdjustments;
	public bool bHasCachedColorAdjustments;
	public FCurveAtlasColorAdjustments CachedColorAdjustments;
}
