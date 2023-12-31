namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataHazinessToSecondaryRoughness : UMaterialExpressionStrataUtilityBase {
	public static UClass StaticClass() {return default;}
	///<summary>The base roughness of the surface. It represented the smoothest part of the reflection.</summary>
	public FExpressionInput BaseRoughness;
	///<summary>Haziness represent the amount of irregularity of the surface. A high value will lead to a second rough specular lobe causing the surface too look `milky`.</summary>
	public FExpressionInput Haziness;
}
