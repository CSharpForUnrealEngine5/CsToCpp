#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataTransmittanceToMFP : UMaterialExpressionStrataUtilityBase {
	///<summary>The colored transmittance for a view perpendicular to the surface. The transmittance for other view orientations will automatically be deduced according to surface thickness.</summary>
	public FExpressionInput TransmittanceColor;
	///<summary>The desired thickness in centimeter. This can be set lower than 0.1mm (= 0.01cm) to enable the Thin lighting model on the slab node for instance.</summary>
	public FExpressionInput Thickness;
}
