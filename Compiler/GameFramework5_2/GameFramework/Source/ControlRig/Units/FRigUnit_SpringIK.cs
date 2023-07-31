#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Spring IK solver uses a verlet integrator to perform an IK solve.</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_SpringIK.h")]
public partial struct FRigUnit_SpringIK {
	public string StartBone;
	public string EndBone;
	public float HierarchyStrength;
	public float EffectorStrength;
	public float EffectorRatio;
	public float RootStrength;
	public float RootRatio;
	public float Damping;
	public FVector PoleVector;
	public bool bFlipPolePlane;
	public EControlRigVectorKind PoleVectorKind;
	public string PoleVectorSpace;
	public FVector PrimaryAxis;
	public FVector SecondaryAxis;
	public bool bLiveSimulation;
	public int Iterations;
	public bool bLimitLocalPosition;
	public bool bPropagateToChildren;
	public FRigUnit_SpringIK_DebugSettings DebugSettings;
	public FRigUnit_SpringIK_WorkData WorkData;
}
