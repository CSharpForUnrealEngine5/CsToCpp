namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rigid body error correction data</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FRigidBodyErrorCorrection {
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
