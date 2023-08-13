namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataUI : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>The output color of the UI element.</summary>
	public FExpressionInput Color;
	///<summary>The coverage of the UI element: the more the value is high, the less the back buffer will be visible.</summary>
	public FExpressionInput Opacity;
}
