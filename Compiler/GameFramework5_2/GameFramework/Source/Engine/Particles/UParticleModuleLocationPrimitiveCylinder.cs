#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Location/ParticleModuleLocationPrimitiveCylinder.h")]
public partial class UParticleModuleLocationPrimitiveCylinder : UParticleModuleLocationPrimitiveBase {
	///<summary>If true, get the particle velocity form the radial distance inside the primitive.</summary>
	public bool RadialVelocity;
	///<summary>The radius of the cylinder.</summary>
	public FRawDistributionFloat StartRadius;
	///<summary>The height of the cylinder, centered about the location.</summary>
	public FRawDistributionFloat StartHeight;
	///<summary>Determine the particle system axis that should represent the height of the cylinder.</summary>
	public CylinderHeightAxis HeightAxis;
}
