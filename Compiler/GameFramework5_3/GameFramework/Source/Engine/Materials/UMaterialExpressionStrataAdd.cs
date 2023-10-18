namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataAdd : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>Substrate material</summary>
	public FExpressionInput A;
	///<summary>Substrate material</summary>
	public FExpressionInput B;
	///<summary>Merge A and B into a single material by mixing their inputs rather than their evaluation. This makes lighting evaluation cheaper (Default: off)</summary>
	public bool bUseParameterBlending;
}
