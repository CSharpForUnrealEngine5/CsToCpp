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
