#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDecalMipmapLevel.h")]
public partial class UMaterialExpressionDecalMipmapLevel : UMaterialExpression {
	///<summary>Defaults to &#39;(Const Width, Const Height)&#39; if not specified</summary>
	public FExpressionInput TextureSize;
	///<summary>only used if TextureSize is not hooked up</summary>
	public float ConstWidth;
	///<summary>ConstHeight</summary>
	public float ConstHeight;
}
