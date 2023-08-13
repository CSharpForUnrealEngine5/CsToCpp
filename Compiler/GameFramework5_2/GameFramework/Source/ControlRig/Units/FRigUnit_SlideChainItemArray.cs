namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Slides an existing chain along itself with control over extrapolation.</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_SlideChain.h")]
public partial struct FRigUnit_SlideChainItemArray {
	public TArray<FRigElementKey> Items;
	public float SlideAmount;
	public bool bPropagateToChildren;
	public FRigUnit_SlideChain_WorkData WorkData;
}
