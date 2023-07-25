#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Information about one contact between a pair of rigid bodies.</summary>
public partial struct FRigidBodyContactInfo {
// RigidBodyContactInfo
	public FVector ContactPosition;
	public FVector ContactNormal;
	public float ContactPenetration;
	public bool bContactProbe;
	public UPhysicalMaterial PhysMaterial;
}
