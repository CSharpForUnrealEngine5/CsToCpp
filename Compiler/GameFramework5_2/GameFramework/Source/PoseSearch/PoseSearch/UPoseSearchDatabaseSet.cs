#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchDatabaseSet.h")]
///<summary>A data asset which holds a collection searchable assets.</summary>
public partial class UPoseSearchDatabaseSet : UPoseSearchSearchableAsset {
// PoseSearchDatabaseSet
	public TArray<FPoseSearchDatabaseSetEntry> AssetsToSearch;
	public bool bEvaluateContinuingPoseFirst;
}
