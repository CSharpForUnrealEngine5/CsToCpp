#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetPhysics.h")]
public partial struct FHairCollisionConstraint {
	public bool SolveCollision;
	public bool ProjectCollision;
	public float StaticFriction;
	public float KineticFriction;
	public float StrandsViscosity;
	public FIntVector GridDimension;
	public float CollisionRadius;
	public FRuntimeFloatCurve RadiusScale;
}
