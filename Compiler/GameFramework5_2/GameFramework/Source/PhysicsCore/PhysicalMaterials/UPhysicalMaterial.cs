#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicalMaterials/PhysicalMaterial.h")]
///<summary>Physical materials are used to define the response of a physical object when interacting dynamically with the world.</summary>
public partial class UPhysicalMaterial : UObject {
// PhysicalMaterial
	public float Friction;
	public float StaticFriction;
	public byte FrictionCombineMode;
	public bool bOverrideFrictionCombineMode;
	public float Restitution;
	public byte RestitutionCombineMode;
	public bool bOverrideRestitutionCombineMode;
	public float Density;
	public float SleepLinearVelocityThreshold;
	public float SleepAngularVelocityThreshold;
	public int SleepCounterThreshold;
	public float RaiseMassToPower;
	public float DestructibleDamageThresholdScale;
	public UDEPRECATED_PhysicalMaterialPropertyBase PhysicalMaterialProperty_DEPRECATED;
	public byte SurfaceType;
}
