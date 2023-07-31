#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material output expression to switch logic according to whether virtual texturing is supported on this project, platform and feature level.</summary>
[CppInclude("Materials/MaterialExpressionVirtualTextureFeatureSwitch.h")]
public partial class UMaterialExpressionVirtualTextureFeatureSwitch : UMaterialExpression {
	///<summary>Used if virtual texture is not supported.</summary>
	public FExpressionInput No;
	///<summary>Used if virtual texture is supported.</summary>
	public FExpressionInput Yes;
}
