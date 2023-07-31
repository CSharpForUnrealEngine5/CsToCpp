#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material output expression to switch logic for a path that renders to runtime virtual texture pages.</summary>
[CppInclude("Materials/MaterialExpressionRuntimeVirtualTextureReplace.h")]
public partial class UMaterialExpressionRuntimeVirtualTextureReplace : UMaterialExpression {
	///<summary>Used by the default rendering passes.</summary>
	public FExpressionInput Default;
	///<summary>Used by the pass that renders to a runtime virtual texture page.</summary>
	public FExpressionInput VirtualTextureOutput;
}
