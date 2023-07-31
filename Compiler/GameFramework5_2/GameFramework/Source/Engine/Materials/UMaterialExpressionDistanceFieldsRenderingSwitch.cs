#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material output expression to switch logic according to whether distance fields renderering is supported on this project and feature level.</summary>
[CppInclude("Materials/MaterialExpressionDistanceFieldsRenderingSwitch.h")]
public partial class UMaterialExpressionDistanceFieldsRenderingSwitch : UMaterialExpression {
	///<summary>Used if distance fields renderering is not supported.</summary>
	public FExpressionInput No;
	///<summary>Used if distance fields renderering is supported.</summary>
	public FExpressionInput Yes;
}
