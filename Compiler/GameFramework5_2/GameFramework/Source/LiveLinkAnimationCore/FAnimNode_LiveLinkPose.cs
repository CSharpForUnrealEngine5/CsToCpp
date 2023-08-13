namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNode_LiveLinkPose.h")]
public partial struct FAnimNode_LiveLinkPose {
	public FPoseLink InputPose;
	public FLiveLinkSubjectName LiveLinkSubjectName;
	public string SubjectName_DEPRECATED;
	public UClass RetargetAsset;
	public ULiveLinkRetargetAsset CurrentRetargetAsset;
}
