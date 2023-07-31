#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>/</summary>
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataHorizontalMixing : UMaterialExpressionStrataBSDF {
	///<summary>Substrate material</summary>
	public FExpressionInput Background;
	///<summary>Substrate material</summary>
	public FExpressionInput Foreground;
	///<summary>Lerp factor between Background (Mix == 0) and Foreground (Mix == 1).</summary>
	public FExpressionInput Mix;
	///<summary>Merge Background and Foreground into a single material by mixing their inputs rather than their evaluation. This makes lighting evaluation cheaper (Default: off)</summary>
	public bool bUseParameterBlending;
}
