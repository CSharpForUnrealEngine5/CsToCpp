#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataEyeBSDF : UMaterialExpressionStrataBSDF {
// MaterialExpressionStrataEyeBSDF
	public FExpressionInput DiffuseColor;
	public FExpressionInput Roughness;
	public FExpressionInput CorneaNormal;
	public FExpressionInput IrisNormal;
	public FExpressionInput IrisPlaneNormal;
	public FExpressionInput IrisMask;
	public FExpressionInput IrisDistance;
	public FExpressionInput EmissiveColor;
	public USubsurfaceProfile SubsurfaceProfile;
}
