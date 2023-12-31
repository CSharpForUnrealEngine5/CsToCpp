namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material output expression to switch logic according to whether virtual texturing is supported on this project, platform and feature level.</summary>
[CppInclude("Materials/MaterialExpressionVirtualTextureFeatureSwitch.h")]
public partial class UMaterialExpressionVirtualTextureFeatureSwitch : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Used if virtual texture is not supported.</summary>
	public FExpressionInput No;
	///<summary>Used if virtual texture is supported.</summary>
	public FExpressionInput Yes;
}
