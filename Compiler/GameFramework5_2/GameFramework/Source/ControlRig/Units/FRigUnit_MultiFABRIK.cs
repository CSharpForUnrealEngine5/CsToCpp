namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The FABRIK solver can solve multi chains within a root using multi effectors</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_MultiFABRIK.h")]
public partial struct FRigUnit_MultiFABRIK {
	public FName RootBone;
	public TArray<FRigUnit_MultiFABRIK_EndEffector> Effectors;
	public float Precision;
	public bool bPropagateToChildren;
	public int MaxIterations;
	public FRigUnit_MultiFABRIK_WorkData WorkData;
	public bool bIsInitialized;
}
