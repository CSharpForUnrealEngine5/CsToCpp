#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigSpaceHierarchy.h")]
public partial struct FRigSpace {
	public ERigSpaceType SpaceType;
	public string ParentName;
	public int ParentIndex;
	public FTransform InitialTransform;
	public FTransform LocalTransform;
}
