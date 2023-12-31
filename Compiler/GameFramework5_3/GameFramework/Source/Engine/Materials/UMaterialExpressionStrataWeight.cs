namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataWeight : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>Substrate material</summary>
	public FExpressionInput A;
	///<summary>Weight to apply to the Substrate material BSDFs</summary>
	public FExpressionInput Weight;
}
