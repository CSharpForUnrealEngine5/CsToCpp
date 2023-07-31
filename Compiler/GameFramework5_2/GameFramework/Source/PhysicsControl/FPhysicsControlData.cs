#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains data associated with how physical bodies should be controlled/directed towards their targets.</summary>
[CppInclude("PhysicsControlData.h")]
public partial struct FPhysicsControlData {
	public float LinearStrength;
	public float LinearDampingRatio;
	public float LinearExtraDamping;
	public float MaxForce;
	public float AngularStrength;
	public float AngularDampingRatio;
	public float AngularExtraDamping;
	public float MaxTorque;
}
