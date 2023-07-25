#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_PropagateTransform.h")]
///<summary>Propagate Transform can be used to force a recalculation of a bone's global transform</summary>
public partial struct FRigUnit_PropagateTransform {
// RigUnit_PropagateTransform
	public FRigElementKey Item;
	public bool bRecomputeGlobal;
	public bool bApplyToChildren;
	public bool bRecursive;
	public FCachedRigElement CachedIndex;
}
