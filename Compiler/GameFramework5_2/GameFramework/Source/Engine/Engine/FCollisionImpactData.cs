#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Information about an overall collision, including contacts.</summary>
public partial struct FCollisionImpactData {
// CollisionImpactData
	public TArray<FRigidBodyContactInfo> ContactInfos;
	public FVector TotalNormalImpulse;
	public FVector TotalFrictionImpulse;
	public bool bIsVelocityDeltaUnderThreshold;
}
