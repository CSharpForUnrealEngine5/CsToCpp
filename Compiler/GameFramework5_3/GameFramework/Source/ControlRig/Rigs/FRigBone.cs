namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigBoneHierarchy.h")]
public partial struct FRigBone {
	public FName ParentName;
	public int ParentIndex;
	public FTransform InitialTransform;
	public FTransform GlobalTransform;
	public FTransform LocalTransform;
	public TArray<int> Dependents;
	public ERigBoneType Type;
}
