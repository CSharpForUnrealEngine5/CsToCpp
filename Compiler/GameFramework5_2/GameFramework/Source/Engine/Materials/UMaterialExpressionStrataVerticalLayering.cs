namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataVerticalLayering : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>Substrate material layer on top of the Base material layer</summary>
	public FExpressionInput Top;
	///<summary>Substrate material layer below the Top material layer</summary>
	public FExpressionInput Base;
	///<summary>Thickness of the Top material layer</summary>
	public FExpressionInput Thickness;
	///<summary>Merge Top and Base into a single material by mixing their inputs rather than their evaluation. This makes lighting evaluation cheaper (Default: off)</summary>
	public bool bUseParameterBlending;
}
