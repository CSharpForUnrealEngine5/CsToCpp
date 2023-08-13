namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes the physical state of a rigid body.</summary>
[CppInclude("Engine/ReplicatedState.h")]
public partial struct FRigidBodyState {
	public FVector_NetQuantize100 Position;
	public FQuat Quaternion;
	public FVector_NetQuantize100 LinVel;
	public FVector_NetQuantize100 AngVel;
	public byte Flags;
}
