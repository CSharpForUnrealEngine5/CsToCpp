#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A data asset which holds a collection searchable assets.</summary>
[CppInclude("PoseSearch/PoseSearchDatabaseSet.h")]
public partial class UPoseSearchDatabaseSet : UPoseSearchSearchableAsset {
	///<summary>AssetsToSearch</summary>
	public TArray<FPoseSearchDatabaseSetEntry> AssetsToSearch;
	///<summary>if there&#39;s a valid continuing pose and bEvaluateContinuingPoseFirst is true, the continuing pose will be evaluated as first search,</summary>
	public bool bEvaluateContinuingPoseFirst;
}
