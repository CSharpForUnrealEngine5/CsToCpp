#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_SlideChain.h")]
///<summary>Slides an existing chain along itself with control over extrapolation.</summary>
public partial struct FRigUnit_SlideChainItemArray {
// RigUnit_SlideChainItemArray
	public TArray<FRigElementKey> Items;
	public float SlideAmount;
	public bool bPropagateToChildren;
	public FRigUnit_SlideChain_WorkData WorkData;
}
