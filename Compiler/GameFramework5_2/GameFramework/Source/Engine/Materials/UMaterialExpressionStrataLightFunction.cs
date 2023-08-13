namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataLightFunction : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>The output color of the light function</summary>
	public FExpressionInput Color;
}
