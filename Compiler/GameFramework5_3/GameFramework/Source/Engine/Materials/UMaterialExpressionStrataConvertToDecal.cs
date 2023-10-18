namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataConvertToDecal : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>The Substrate material to convert to a decal.</summary>
	public FExpressionInput DecalMaterial;
	///<summary>The coverage of the decal (default 1)</summary>
	public FExpressionInput Coverage;
}
