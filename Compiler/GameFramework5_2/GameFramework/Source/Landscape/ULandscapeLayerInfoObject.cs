#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeLayerInfoObject.h")]
public partial class ULandscapeLayerInfoObject : UObject {
// LandscapeLayerInfoObject
	public string LayerName;
	public UPhysicalMaterial PhysMaterial;
	public float Hardness;
	public float MinimumCollisionRelevanceWeight;
	public bool bNoWeightBlend;
	public UTexture2D SplineFalloffModulationTexture;
	public ESplineModulationColorMask SplineFalloffModulationColorMask;
	public float SplineFalloffModulationTiling;
	public float SplineFalloffModulationBias;
	public float SplineFalloffModulationScale;
	public bool IsReferencedFromLoadedData;
	public FLinearColor LayerUsageDebugColor;
}
