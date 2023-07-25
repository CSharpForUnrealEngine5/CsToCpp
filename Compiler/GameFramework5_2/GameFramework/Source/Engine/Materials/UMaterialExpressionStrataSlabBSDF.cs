#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataSlabBSDF : UMaterialExpressionStrataBSDF {
// MaterialExpressionStrataSlabBSDF
	public FExpressionInput DiffuseAlbedo;
	public FExpressionInput F0;
	public FExpressionInput F90;
	public FExpressionInput Roughness;
	public FExpressionInput Anisotropy;
	public FExpressionInput Normal;
	public FExpressionInput Tangent;
	public FExpressionInput SSSMFP;
	public FExpressionInput SSSMFPScale;
	public FExpressionInput SSSPhaseAnisotropy;
	public FExpressionInput EmissiveColor;
	public FExpressionInput SecondRoughness;
	public FExpressionInput SecondRoughnessWeight;
	public FExpressionInput FuzzRoughness;
	public FExpressionInput FuzzAmount;
	public FExpressionInput FuzzColor;
	public USubsurfaceProfile SubsurfaceProfile;
	public bool bUseSSSDiffusion;
}
