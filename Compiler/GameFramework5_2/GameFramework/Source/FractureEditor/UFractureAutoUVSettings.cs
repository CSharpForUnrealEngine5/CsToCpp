#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolUV.h")]
///<summary>Settings for UV layout and texture baking on the geometry collection *</summary>
public partial class UFractureAutoUVSettings : UFractureToolSettings {
// FractureAutoUVSettings
	public string UVChannel;
	public  TArray<string> GetUVChannelNamesFunc() { return default; }
	public TArray<string> UVChannelNamesList;
	public  void AddUVChannel() {}
	public  void DeleteUVChannel() {}
	public  void LayoutUVs() {}
	public  void BakeTexture() {}
	public  void DisableBoneColors() {}
	public FVector ProjectionScale;
	public bool bAutoFitToBounds;
	public bool bUniformProjectionScale;
	public FVector2D ProjectionUVOffset;
	public bool bCenterAtPivot;
	public  void BoxProjectUVs() {}
	public ETargetMaterialIDs TargetMaterialIDs;
	public TArray<int> MaterialIDs;
	public EAutoUVTextureResolution Resolution;
	public int GutterSize;
	public UTexture2D Result;
	public bool bPromptToSave;
	public bool bReplaceExisting;
	public ETextureType BakeTextureType;
	public bool bDistToOuter;
	public bool bAmbientOcclusion;
	public bool bSmoothedCurvature;
	public double MaxDistance;
	public int OcclusionRays;
	public double OcclusionBlurRadius;
	public double CurvatureBlurRadius;
	public int VoxelResolution;
	public int SmoothingIterations;
	public double ThicknessFactor;
	public double MaxCurvature;
}
