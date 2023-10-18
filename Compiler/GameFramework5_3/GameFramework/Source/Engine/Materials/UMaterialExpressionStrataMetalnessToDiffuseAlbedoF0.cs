namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataMetalnessToDiffuseAlbedoF0 : UMaterialExpressionStrataUtilityBase {
	public static UClass StaticClass() {return default;}
	///<summary>Defines the overall color of the Material. (type = float3, unit = unitless, defaults to 0.18)</summary>
	public FExpressionInput BaseColor;
	///<summary>Controls how \&quot;metal-like\&quot; your surface looks like. 0 means dielectric, 1 means conductor (type = float, unit = unitless, defaults to 0)</summary>
	public FExpressionInput Metallic;
	///<summary>Used to scale the current amount of specularity on non-metallic surfaces and is a value between 0 and 1 (type = float, unit = unitless, defaults to plastic 0.5)</summary>
	public FExpressionInput Specular;
}
