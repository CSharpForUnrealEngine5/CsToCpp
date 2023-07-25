#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/Skeleton.h")]
///<summary>This is a mapping table between bone in a particular skeletal mesh and bone of this skeleton set.</summary>
public partial struct FReferencePose {
// ReferencePose
	public string PoseName;
	public TArray<FTransform> ReferencePose;
	public TSoftObjectPtr<USkeletalMesh> SourceReferenceMesh;
}
