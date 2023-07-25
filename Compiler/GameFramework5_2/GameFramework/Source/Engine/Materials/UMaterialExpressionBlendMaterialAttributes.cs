#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionBlendMaterialAttributes.h")]
public partial class UMaterialExpressionBlendMaterialAttributes : UMaterialExpression {
// MaterialExpressionBlendMaterialAttributes
	public FMaterialAttributesInput A;
	public FMaterialAttributesInput B;
	public FExpressionInput Alpha;
	public byte PixelAttributeBlendType;
	public byte VertexAttributeBlendType;
}
