namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Node which outputs a texture object contained in a UHeightfieldMinMaxTexture.</summary>
[CppInclude("HeightfieldMinMaxTextureMaterialExpression.h")]
public partial class UMaterialExpressionHeightfieldMinMaxTexture : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>MinMaxTexture</summary>
	public UHeightfieldMinMaxTexture MinMaxTexture;
	///<summary>SamplerType</summary>
	public EMaterialSamplerType SamplerType;
}
