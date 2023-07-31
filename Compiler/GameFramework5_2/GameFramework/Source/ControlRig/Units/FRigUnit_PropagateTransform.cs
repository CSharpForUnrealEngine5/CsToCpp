#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Propagate Transform can be used to force a recalculation of a bone&#39;s global transform</summary>
[CppInclude("Units/Hierarchy/RigUnit_PropagateTransform.h")]
public partial struct FRigUnit_PropagateTransform {
	public FRigElementKey Item;
	public bool bRecomputeGlobal;
	public bool bApplyToChildren;
	public bool bRecursive;
	public FCachedRigElement CachedIndex;
}
