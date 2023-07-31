#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionBlendMaterialAttributes.h")]
public partial class UMaterialExpressionBlendMaterialAttributes : UMaterialExpression {
	///<summary>A</summary>
	public FMaterialAttributesInput A;
	///<summary>B</summary>
	public FMaterialAttributesInput B;
	///<summary>Alpha</summary>
	public FExpressionInput Alpha;
	///<summary>Optionally skip blending attributes of this type.</summary>
	public EMaterialAttributeBlend PixelAttributeBlendType;
	///<summary>Optionally skip blending attributes of this type.</summary>
	public EMaterialAttributeBlend VertexAttributeBlendType;
}
