#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Rigid body error correction data</summary>
public partial struct FRigidBodyErrorCorrection {
// RigidBodyErrorCorrection
	public float PingExtrapolation;
	public float PingLimit;
	public float ErrorPerLinearDifference;
	public float ErrorPerAngularDifference;
	public float MaxRestoredStateError;
	public float MaxLinearHardSnapDistance;
	public float PositionLerp;
	public float AngleLerp;
	public float LinearVelocityCoefficient;
	public float AngularVelocityCoefficient;
	public float ErrorAccumulationSeconds;
	public float ErrorAccumulationDistanceSq;
	public float ErrorAccumulationSimilarity;
}
