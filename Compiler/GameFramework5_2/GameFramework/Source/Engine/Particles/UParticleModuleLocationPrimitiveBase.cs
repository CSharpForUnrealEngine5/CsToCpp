#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Location/ParticleModuleLocationPrimitiveBase.h")]
public partial class UParticleModuleLocationPrimitiveBase : UParticleModuleLocationBase {
// ParticleModuleLocationPrimitiveBase
	public bool Positive_X;
	public bool Positive_Y;
	public bool Positive_Z;
	public bool Negative_X;
	public bool Negative_Y;
	public bool Negative_Z;
	public bool SurfaceOnly;
	public bool Velocity;
	public FRawDistributionFloat VelocityScale;
	public FRawDistributionVector StartLocation;
}
