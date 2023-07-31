#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataConvertToDecal : UMaterialExpressionStrataBSDF {
	///<summary>The Substrate material to convert to a decal.</summary>
	public FExpressionInput DecalMaterial;
	///<summary>The coverage of the decal (default 1)</summary>
	public FExpressionInput Coverage;
}
