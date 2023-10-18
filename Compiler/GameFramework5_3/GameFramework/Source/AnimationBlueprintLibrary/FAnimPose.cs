namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script friendly representation of an evaluated animation bone pose</summary>
[CppInclude("AnimPose.h")]
public partial struct FAnimPose {
	public TArray<FName> BoneNames;
	public TArray<int> BoneIndices;
	public TArray<int> ParentBoneIndices;
	public TArray<FTransform> LocalSpacePoses;
	public TArray<FTransform> WorldSpacePoses;
	public TArray<FTransform> RefLocalSpacePoses;
	public TArray<FTransform> RefWorldSpacePoses;
	public TArray<FName> CurveNames;
	public TArray<float> CurveValues;
	public TArray<FName> SocketNames;
	public TArray<FName> SocketParentBoneNames;
	public TArray<FTransform> SocketTransforms;
}
