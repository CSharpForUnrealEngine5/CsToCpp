#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script friendly representation of an evaluated animation bone pose</summary>
[CppInclude("AnimPose.h")]
public partial struct FAnimPose {
	public TArray<string> BoneNames;
	public TArray<int> BoneIndices;
	public TArray<int> ParentBoneIndices;
	public TArray<FTransform> LocalSpacePoses;
	public TArray<FTransform> WorldSpacePoses;
	public TArray<FTransform> RefLocalSpacePoses;
	public TArray<FTransform> RefWorldSpacePoses;
	public TArray<string> CurveNames;
	public TArray<float> CurveValues;
}
