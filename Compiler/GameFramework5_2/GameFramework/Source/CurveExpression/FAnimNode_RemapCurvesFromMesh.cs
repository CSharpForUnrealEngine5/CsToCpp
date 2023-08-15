namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNode_RemapCurvesFromMesh.h")]
public partial struct FAnimNode_RemapCurvesFromMesh {
	public FPoseLink SourcePose;
	public TWeakObjectPtr<USkeletalMeshComponent> SourceMeshComponent;
	public bool bUseAttachedParent;
	public TMap<FName,string> CurveExpressions;
	public bool bExpressionsImmutable;
}
