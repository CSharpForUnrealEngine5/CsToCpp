#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HeightfieldMinMaxTextureMaterialExpression.h")]
///<summary>Node which outputs a texture object contained in a UHeightfieldMinMaxTexture.</summary>
public partial class UMaterialExpressionHeightfieldMinMaxTexture : UMaterialExpression {
// MaterialExpressionHeightfieldMinMaxTexture
	public UHeightfieldMinMaxTexture MinMaxTexture;
	public EMaterialSamplerType SamplerType;
}
