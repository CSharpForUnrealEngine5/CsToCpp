#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_ProjectTransformToNewParent.h")]
///<summary>Gets the relative offset between the child and the old parent, then multiplies by new parent's transform.</summary>
public partial struct FRigUnit_ProjectTransformToNewParent {
// RigUnit_ProjectTransformToNewParent
	public FRigElementKey Child;
	public bool bChildInitial;
	public FRigElementKey OldParent;
	public bool bOldParentInitial;
	public FRigElementKey NewParent;
	public bool bNewParentInitial;
	public FTransform Transform;
	public FCachedRigElement CachedChild;
	public FCachedRigElement CachedOldParent;
	public FCachedRigElement CachedNewParent;
}
