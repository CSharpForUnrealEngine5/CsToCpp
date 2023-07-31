#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Gets the relative offset between the child and the old parent, then multiplies by new parent&#39;s transform.</summary>
[CppInclude("Units/Hierarchy/RigUnit_ProjectTransformToNewParent.h")]
public partial struct FRigUnit_ProjectTransformToNewParent {
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
