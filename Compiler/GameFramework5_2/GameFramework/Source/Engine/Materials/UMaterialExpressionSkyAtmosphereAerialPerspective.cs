#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSkyAtmosphereLightIlluminance.h")]
public partial class UMaterialExpressionSkyAtmosphereAerialPerspective : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>World position of the sample. If not specified, the pixel world position will be used. Larger distance will result in more fog. Please make sure .SkyAtmosphere.AerialPerspectiveLUT.Depth is set far enough to have fog data.</summary>
	public FExpressionInput WorldPosition;
}
