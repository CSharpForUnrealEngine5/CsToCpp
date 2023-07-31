#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for UV layout and texture baking on the geometry collection *</summary>
[CppInclude("FractureToolUV.h")]
public partial class UFractureAutoUVSettings : UFractureToolSettings {
	///<summary>Which UV channel to use for layout and baking</summary>
	public string UVChannel;
	///<summary>GetUVChannelNamesFunc</summary>
	public  TArray<string> GetUVChannelNamesFunc() { return default; }
	///<summary>UVChannelNamesList</summary>
	public TArray<string> UVChannelNamesList;
	///<summary>Add a UV channel to the Geometry Collection</summary>
	public  void AddUVChannel() {}
	///<summary>Remove the last UV channel from the Geometry Collection</summary>
	public  void DeleteUVChannel() {}
	///<summary>Immediately layout and update the UVs of the selected Geometry Collection, for faces with the Target Material IDs</summary>
	public  void LayoutUVs() {}
	///<summary>Bake a new texture with the chosen attributes, aligned to the current UV layout</summary>
	public  void BakeTexture() {}
	///<summary>Disable &quot;Show Bone Colors&quot; on the selected Geometry Collection Components, so textures are visible. This setting can also be toggled directly on the Component itself</summary>
	public  void DisableBoneColors() {}
	///<summary>The scale factor to use for UV box projection</summary>
	public FVector ProjectionScale;
	///<summary>Set the scale factor for UV box projection based on the bounding box of the geometry</summary>
	public bool bAutoFitToBounds;
	///<summary>Ensure the projection scale is the same on each axis, either by repeating the X Axis scale, or using the max box dimension if Auto Fit to Bounds is selected.</summary>
	public bool bUniformProjectionScale;
	///<summary>UV Offset to apply after UV box projection</summary>
	public FVector2D ProjectionUVOffset;
	///<summary>Optionally center the UV projection around the object pivot</summary>
	public bool bCenterAtPivot;
	///<summary>Immediately perform a box projection to update the internal UVs of the selected Geometry Collection</summary>
	public  void BoxProjectUVs() {}
	///<summary>Choose whether to texture only faces with odd material IDs (corresponding to internal faces) or a custom selection</summary>
	public ETargetMaterialIDs TargetMaterialIDs;
	///<summary>Custom selection of material IDs to target for texturing</summary>
	public TArray<int> MaterialIDs;
	///<summary>The pixel resolution of the generated map</summary>
	public EAutoUVTextureResolution Resolution;
	///<summary>Approximate space to leave between UV islands, measured in texels</summary>
	public int GutterSize;
	///<summary>The resulting automatically-generated texture map</summary>
	public UTexture2D Result;
	///<summary>Whether to prompt user for an asset name for each generated texture, or automatically place them next to the source Geometry Collections</summary>
	public bool bPromptToSave;
	///<summary>Whether to allow the new texture to overwrite an existing texture</summary>
	public bool bReplaceExisting;
	///<summary>Which standard set of texture channels to bake</summary>
	public ETextureType BakeTextureType;
	///<summary>Bake the distance to the external surface to a texture channel (red)</summary>
	public bool bDistToOuter;
	///<summary>Bake the ambient occlusion of each bone (considered separately) to a texture channel (green)</summary>
	public bool bAmbientOcclusion;
	///<summary>Bake a smoothed curvature metric to a texture channel (blue)</summary>
	public bool bSmoothedCurvature;
	///<summary>Max distance to search for the outer mesh surface</summary>
	public double MaxDistance;
	///<summary>Number of occlusion rays</summary>
	public int OcclusionRays;
	///<summary>Pixel Radius of Gaussian Blur Kernel applied to AO map (0 will apply no blur)</summary>
	public double OcclusionBlurRadius;
	///<summary>Pixel Radius of Gaussian Blur Kernel applied to Curvature map (0 will apply no blur)</summary>
	public double CurvatureBlurRadius;
	///<summary>Voxel resolution of smoothed shape representation</summary>
	public int VoxelResolution;
	///<summary>Amount of smoothing iterations to apply before computing curvature</summary>
	public int SmoothingIterations;
	///<summary>Distance to search for correspondence between fractured shape and smoothed shape, as factor of voxel size</summary>
	public double ThicknessFactor;
	///<summary>Curvatures in the range [-MaxCurvature, MaxCurvature] will be mapped from [0,1]. Values outside that range will be clamped</summary>
	public double MaxCurvature;
}
