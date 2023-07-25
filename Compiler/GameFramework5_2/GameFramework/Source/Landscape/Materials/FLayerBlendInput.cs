#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionLandscapeLayerBlend.h")]
public partial struct FLayerBlendInput {
// LayerBlendInput
	public string LayerName;
	public byte BlendType;
	public FExpressionInput LayerInput;
	public FExpressionInput HeightInput;
	public float PreviewWeight;
	public FVector ConstLayerInput;
	public float ConstHeightInput;
}
