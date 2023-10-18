namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rig/IKRigSkeleton.h")]
public partial struct FIKRigSkeleton {
	public TArray<FName> BoneNames;
	public TArray<int> ParentIndices;
	public TArray<FName> ExcludedBones;
	public TArray<FTransform> CurrentPoseGlobal;
	public TArray<FTransform> CurrentPoseLocal;
	public TArray<FTransform> RefPoseGlobal;
}
