namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_SpringIK.h")]
public partial struct FRigUnit_SpringIK_WorkData {
	public TArray<FCachedRigElement> CachedBones;
	public FCachedRigElement CachedPoleVector;
	public TArray<FTransform> Transforms;
	public FCRSimPointContainer Simulation;
}
