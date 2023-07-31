#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSkyAtmosphereLightIlluminance.h")]
public partial class UMaterialExpressionSkyAtmosphereLightDiskLuminance : UMaterialExpression {
	///<summary>Index of the atmosphere light to sample.</summary>
	public int LightIndex;
	///<summary>Override the angular diameter of the disk in degree. If not specified, the radius specified on the directional light will be used. This can be used to decouple the directional light visual disk size used for the specular disk reflection on surfaces. However, be aware that screen space reflections will still catch the visual disk.</summary>
	public FExpressionInput DiskAngularDiameterOverride;
}
