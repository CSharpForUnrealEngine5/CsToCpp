#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A data asset for indexing a collection of animation sequences.</summary>
[CppInclude("PoseSearch/PoseSearchDatabase.h")]
public partial class UPoseSearchDatabase : UPoseSearchSearchableAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Motion Database Config asset to use with this database.</summary>
	public UPoseSearchSchema Schema;
	///<summary>ExtrapolationParameters</summary>
	public FPoseSearchExtrapolationParameters ExtrapolationParameters;
	///<summary>ExcludeFromDatabaseParameters</summary>
	public FPoseSearchExcludeFromDatabaseParameters ExcludeFromDatabaseParameters;
	///<summary>Sequences and Blendspaces are deprecated and its data will be part of the AnimationAssets.</summary>
	public TArray<FPoseSearchDatabaseSequence> Sequences_DEPRECATED;
	///<summary>BlendSpaces_DEPRECATED</summary>
	public TArray<FPoseSearchDatabaseBlendSpace> BlendSpaces_DEPRECATED;
	///<summary>AnimationAssets</summary>
	public TArray<FInstancedStruct> AnimationAssets;
	///<summary>PoseSearchMode</summary>
	public EPoseSearchMode PoseSearchMode;
	///<summary>NumberOfPrincipalComponents</summary>
	public int NumberOfPrincipalComponents;
	///<summary>KDTreeMaxLeafSize</summary>
	public int KDTreeMaxLeafSize;
	///<summary>KDTreeQueryNumNeighbors</summary>
	public int KDTreeQueryNumNeighbors;
	///<summary>if true, this database search will be skipped if cannot decrease the pose cost, and poses will not be listed into the PoseSearchDebugger</summary>
	public bool bSkipSearchIfPossible;
	///<summary>NormalizationSet</summary>
	public UNormalizationSetAsset NormalizationSet;
	///<summary>SearchIndexPrivate</summary>
	public FPoseSearchIndex SearchIndexPrivate;
}
