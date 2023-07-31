#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a mapping table between bone in a particular skeletal mesh and bone of this skeleton set.</summary>
[CppInclude("Animation/Skeleton.h")]
public partial struct FSkeletonToMeshLinkup {
	public TArray<int> SkeletonToMeshTable;
	public TArray<int> MeshToSkeletonTable;
}
