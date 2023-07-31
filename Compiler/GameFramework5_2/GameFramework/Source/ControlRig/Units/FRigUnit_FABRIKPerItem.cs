#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The FABRIK solver can solve N-Bone chains using</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_FABRIK.h")]
public partial struct FRigUnit_FABRIKPerItem {
	public FRigElementKeyCollection Items;
	public FTransform EffectorTransform;
	public float Precision;
	public float Weight;
	public bool bPropagateToChildren;
	public int MaxIterations;
	public FRigUnit_FABRIK_WorkData WorkData;
	public bool bSetEffectorTransform;
}
