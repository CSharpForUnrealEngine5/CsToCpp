#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSkyAtmosphereLightIlluminance.h")]
public partial class UMaterialExpressionSkyAtmosphereLightIlluminance : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Index of the atmosphere light to sample.</summary>
	public int LightIndex;
	///<summary>World position of the sample. If not specified, the pixel world position will be used.</summary>
	public FExpressionInput WorldPosition;
}
