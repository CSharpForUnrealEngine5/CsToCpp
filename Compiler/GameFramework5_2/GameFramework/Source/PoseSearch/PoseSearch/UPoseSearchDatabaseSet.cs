namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A data asset which holds a collection searchable assets.</summary>
[CppInclude("PoseSearch/PoseSearchDatabaseSet.h")]
public partial class UPoseSearchDatabaseSet : UPoseSearchSearchableAsset {
	public static UClass StaticClass() {return default;}
	///<summary>AssetsToSearch</summary>
	public TArray<FPoseSearchDatabaseSetEntry> AssetsToSearch;
	///<summary>if there&#39;s a valid continuing pose and bEvaluateContinuingPoseFirst is true, the continuing pose will be evaluated as first search,</summary>
	public bool bEvaluateContinuingPoseFirst;
}
