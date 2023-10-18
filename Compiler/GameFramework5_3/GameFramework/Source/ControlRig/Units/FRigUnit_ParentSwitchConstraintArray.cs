namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Parent Switch Constraint is used to have an item follow one of multiple parents,</summary>
[CppInclude("Units/Hierarchy/RigUnit_ParentSwitchConstraint.h")]
public partial struct FRigUnit_ParentSwitchConstraintArray {
	public FRigElementKey Subject;
	public int ParentIndex;
	public TArray<FRigElementKey> Parents;
	public FTransform InitialGlobalTransform;
	public float Weight;
	public FTransform Transform;
	public bool Switched;
	public FCachedRigElement CachedSubject;
	public FCachedRigElement CachedParent;
	public FTransform RelativeOffset;
}
