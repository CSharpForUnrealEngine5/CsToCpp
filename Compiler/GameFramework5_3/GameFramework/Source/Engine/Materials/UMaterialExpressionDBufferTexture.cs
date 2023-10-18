namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDBufferTexture.h")]
public partial class UMaterialExpressionDBufferTexture : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Ignored if not specified</summary>
	public FExpressionInput Coordinates;
	///<summary>Which DBuffer texture we want to make a lookup into.</summary>
	public EDBufferTextureId DBufferTextureId;
}
