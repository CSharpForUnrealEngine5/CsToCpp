#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_MultiFABRIK.h")]
///<summary>The FABRIK solver can solve multi chains within a root using multi effectors</summary>
public partial struct FRigUnit_MultiFABRIK {
// RigUnit_MultiFABRIK
	public string RootBone;
	public TArray<FRigUnit_MultiFABRIK_EndEffector> Effectors;
	public float Precision;
	public bool bPropagateToChildren;
	public int MaxIterations;
	public FRigUnit_MultiFABRIK_WorkData WorkData;
	public bool bIsInitialized;
}
