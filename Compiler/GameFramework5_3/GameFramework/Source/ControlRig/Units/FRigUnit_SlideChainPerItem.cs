namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Slides an existing chain along itself with control over extrapolation.</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_SlideChain.h")]
public partial struct FRigUnit_SlideChainPerItem {
	public FRigElementKeyCollection Items;
	public float SlideAmount;
	public bool bPropagateToChildren;
	public FRigUnit_SlideChain_WorkData WorkData;
}
