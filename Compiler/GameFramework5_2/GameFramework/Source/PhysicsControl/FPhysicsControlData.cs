#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlData.h")]
///<summary>Contains data associated with how physical bodies should be controlled/directed towards their targets.</summary>
public partial struct FPhysicsControlData {
// PhysicsControlData
	public float LinearStrength;
	public float LinearDampingRatio;
	public float LinearExtraDamping;
	public float MaxForce;
	public float AngularStrength;
	public float AngularDampingRatio;
	public float AngularExtraDamping;
	public float MaxTorque;
}
