#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionShaderStageSwitch.h")]
public partial class UMaterialExpressionShaderStageSwitch : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input will be used in pixel (or compute) shader stages</summary>
	public FExpressionInput PixelShader;
	///<summary>Input will be in vertex (or tessellation) shader stages</summary>
	public FExpressionInput VertexShader;
}
