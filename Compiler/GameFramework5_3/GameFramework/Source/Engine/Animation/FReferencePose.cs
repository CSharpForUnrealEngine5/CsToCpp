namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a mapping table between bone in a particular skeletal mesh and bone of this skeleton set.</summary>
[CppInclude("Animation/Skeleton.h")]
public partial struct FReferencePose {
	public FName PoseName;
	public TArray<FTransform> ReferencePose;
	public TSoftObjectPtr<USkeletalMesh> SourceReferenceMesh;
}
