#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigBoneHierarchy.h")]
public partial struct FRigBone {
	public string ParentName;
	public int ParentIndex;
	public FTransform InitialTransform;
	public FTransform GlobalTransform;
	public FTransform LocalTransform;
	public TArray<int> Dependents;
	public ERigBoneType Type;
}
