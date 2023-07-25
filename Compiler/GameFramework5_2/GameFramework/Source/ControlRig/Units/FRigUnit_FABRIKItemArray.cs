#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_FABRIK.h")]
///<summary>The FABRIK solver can solve N-Bone chains using</summary>
public partial struct FRigUnit_FABRIKItemArray {
// RigUnit_FABRIKItemArray
	public TArray<FRigElementKey> Items;
	public FTransform EffectorTransform;
	public float Precision;
	public float Weight;
	public bool bPropagateToChildren;
	public int MaxIterations;
	public FRigUnit_FABRIK_WorkData WorkData;
	public bool bSetEffectorTransform;
}
