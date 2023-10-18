namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about an overall collision, including contacts.</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FCollisionImpactData {
	public TArray<FRigidBodyContactInfo> ContactInfos;
	public FVector TotalNormalImpulse;
	public FVector TotalFrictionImpulse;
	public bool bIsVelocityDeltaUnderThreshold;
}
