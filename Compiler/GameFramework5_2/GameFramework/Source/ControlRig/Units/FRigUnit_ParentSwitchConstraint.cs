#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_ParentSwitchConstraint.h")]
///<summary>The Parent Switch Constraint is used to have an item follow one of multiple parents,</summary>
public partial struct FRigUnit_ParentSwitchConstraint {
// RigUnit_ParentSwitchConstraint
	public FRigElementKey Subject;
	public int ParentIndex;
	public FRigElementKeyCollection Parents;
	public FTransform InitialGlobalTransform;
	public float Weight;
	public FTransform Transform;
	public bool Switched;
	public FCachedRigElement CachedSubject;
	public FCachedRigElement CachedParent;
	public FTransform RelativeOffset;
}
