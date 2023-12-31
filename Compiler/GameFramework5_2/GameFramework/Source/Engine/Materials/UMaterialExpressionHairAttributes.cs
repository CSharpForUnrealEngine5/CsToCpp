namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionHairAttributes.h")]
public partial class UMaterialExpressionHairAttributes : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled, this nodes outputs a tangent space tangent, otherwise it outputs a world space tangent.</summary>
	public bool bUseTangentSpace;
}
