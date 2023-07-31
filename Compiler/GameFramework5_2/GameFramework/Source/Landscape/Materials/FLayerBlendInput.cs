#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionLandscapeLayerBlend.h")]
public partial struct FLayerBlendInput {
	public string LayerName;
	public ELandscapeLayerBlendType BlendType;
	public FExpressionInput LayerInput;
	public FExpressionInput HeightInput;
	public float PreviewWeight;
	public FVector ConstLayerInput;
	public float ConstHeightInput;
}
