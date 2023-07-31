#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Node which outputs a texture object contained in a UHeightfieldMinMaxTexture.</summary>
[CppInclude("HeightfieldMinMaxTextureMaterialExpression.h")]
public partial class UMaterialExpressionHeightfieldMinMaxTexture : UMaterialExpression {
	///<summary>MinMaxTexture</summary>
	public UHeightfieldMinMaxTexture MinMaxTexture;
	///<summary>SamplerType</summary>
	public EMaterialSamplerType SamplerType;
}
