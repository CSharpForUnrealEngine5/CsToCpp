#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/RecomputeUVsProperties.h")]
public partial class URecomputeUVsToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>bEnablePolygroupSupport</summary>
	public bool bEnablePolygroupSupport;
	///<summary>Generation method for initial UV islands.</summary>
	public ERecomputeUVsPropertiesIslandMode IslandGeneration;
	///<summary>Type of UV flattening algorithm to use</summary>
	public ERecomputeUVsPropertiesUnwrapType UnwrapType;
	///<summary>Type of automatic rotation applied to each UV island</summary>
	public ERecomputeUVsToolOrientationMode AutoRotation;
	///<summary>If enabled, reduces distortion for meshes with triangles of vastly different sizes, This is only enabled if the Unwrap Type is set to Spectral Conformal.</summary>
	public bool bPreserveIrregularity;
	///<summary>Number of smoothing steps to apply; this slightly increases distortion but produces more stable results. This is only enabled if the Unwrap Type is set to ExpMap or Island Merging.</summary>
	public int SmoothingSteps;
	///<summary>Smoothing parameter; larger values result in faster smoothing in each step. This is only enabled if the Unwrap Type is set to ExpMap or Island Merging.</summary>
	public float SmoothingAlpha;
	///<summary>Threshold for stretching and distortion below which island merging is allowed; larger values increase the allowable UV distortion. This is only enabled if the Unwrap Type is set to Island Merging.</summary>
	public float MergingDistortionThreshold;
	///<summary>Threshold for the average face normal deviation below  which island merging is allowed. This is only enabled if the Unwrap Type is set to Island Merging.</summary>
	public float MergingAngleThreshold;
	///<summary>Uniformly scale and translate UV islands collectively to pack them into the unit square, i.e. fit between 0 and 1 with no overlap.</summary>
	public ERecomputeUVsPropertiesLayoutType LayoutType;
	///<summary>Expected resolution of the output textures; this controls spacing left between UV islands to avoid interpolation artifacts. This is only enabled when the Layout Type is set to Repack.</summary>
	public int TextureResolution;
	///<summary>Scaling factor used for UV island normalization/scaling. This is only enabled when the Layout Type is set to Normalize to Bounds or Normalize to World.</summary>
	public float NormalizeScale;
	///<summary>Enable UDIM aware layout and keep islands within their originating UDIM tiles when laying out.</summary>
	public bool bEnableUDIMLayout;
	///<summary>bUDIMCVAREnabled</summary>
	public bool bUDIMCVAREnabled;
}
