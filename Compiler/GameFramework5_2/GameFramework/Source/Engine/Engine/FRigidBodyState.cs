#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ReplicatedState.h")]
///<summary>Describes the physical state of a rigid body.</summary>
public partial struct FRigidBodyState {
// RigidBodyState
	public FVector_NetQuantize100 Position;
	public FQuat Quaternion;
	public FVector_NetQuantize100 LinVel;
	public FVector_NetQuantize100 AngVel;
	public byte Flags;
}
