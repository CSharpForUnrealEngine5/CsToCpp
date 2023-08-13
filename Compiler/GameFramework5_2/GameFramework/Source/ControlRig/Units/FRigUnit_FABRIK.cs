namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The FABRIK solver can solve N-Bone chains using</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_FABRIK.h")]
public partial struct FRigUnit_FABRIK {
	public string StartBone;
	public string EffectorBone;
	public FTransform EffectorTransform;
	public float Precision;
	public float Weight;
	public bool bPropagateToChildren;
	public int MaxIterations;
	public FRigUnit_FABRIK_WorkData WorkData;
	public bool bSetEffectorTransform;
}
