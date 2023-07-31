#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeLayerInfoObject.h")]
public partial class ULandscapeLayerInfoObject : UObject {
	///<summary>LayerName</summary>
	public string LayerName;
	///<summary>PhysMaterial</summary>
	public UPhysicalMaterial PhysMaterial;
	///<summary>Hardness</summary>
	public float Hardness;
	///<summary>The minimum weight that needs to be painted for that layer to be picked up as the dominant physical layer</summary>
	public float MinimumCollisionRelevanceWeight;
	///<summary>bNoWeightBlend</summary>
	public bool bNoWeightBlend;
	///<summary>Texture to modulate the Splines Falloff Layer Alpha</summary>
	public UTexture2D SplineFalloffModulationTexture;
	///<summary>SplineFalloffModulationColorMask</summary>
	public ESplineModulationColorMask SplineFalloffModulationColorMask;
	///<summary>SplineFalloffModulationTiling</summary>
	public float SplineFalloffModulationTiling;
	///<summary>SplineFalloffModulationBias</summary>
	public float SplineFalloffModulationBias;
	///<summary>SplineFalloffModulationScale</summary>
	public float SplineFalloffModulationScale;
	///<summary>IsReferencedFromLoadedData</summary>
	public bool IsReferencedFromLoadedData;
	///<summary>The color to use for layer usage debug</summary>
	public FLinearColor LayerUsageDebugColor;
}
