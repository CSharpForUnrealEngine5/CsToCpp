namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about one contact between a pair of rigid bodies.</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FRigidBodyContactInfo {
	public FVector ContactPosition;
	public FVector ContactNormal;
	public float ContactPenetration;
	public bool bContactProbe;
	public UPhysicalMaterial PhysMaterial;
}
