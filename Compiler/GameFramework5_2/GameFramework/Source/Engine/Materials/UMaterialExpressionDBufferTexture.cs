#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDBufferTexture.h")]
public partial class UMaterialExpressionDBufferTexture : UMaterialExpression {
	///<summary>Ignored if not specified</summary>
	public FExpressionInput Coordinates;
	///<summary>Which DBuffer texture we want to make a lookup into.</summary>
	public EDBufferTextureId DBufferTextureId;
}
