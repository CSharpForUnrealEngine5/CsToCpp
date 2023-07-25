#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchDatabase.h")]
///<summary>A data asset for indexing a collection of animation sequences.</summary>
public partial class UPoseSearchDatabase : UPoseSearchSearchableAsset {
// PoseSearchDatabase
	public UPoseSearchSchema Schema;
	public FPoseSearchExtrapolationParameters ExtrapolationParameters;
	public FPoseSearchExcludeFromDatabaseParameters ExcludeFromDatabaseParameters;
	public TArray<FPoseSearchDatabaseSequence> Sequences_DEPRECATED;
	public TArray<FPoseSearchDatabaseBlendSpace> BlendSpaces_DEPRECATED;
	public TArray<FInstancedStruct> AnimationAssets;
	public EPoseSearchMode PoseSearchMode;
	public int NumberOfPrincipalComponents;
	public int KDTreeMaxLeafSize;
	public int KDTreeQueryNumNeighbors;
	public bool bSkipSearchIfPossible;
	public UNormalizationSetAsset NormalizationSet;
	public FPoseSearchIndex SearchIndexPrivate;
}
