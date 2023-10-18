namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A data asset for indexing a collection of animation sequences.</summary>
[CppInclude("PoseSearch/PoseSearchDatabase.h")]
public partial class UPoseSearchDatabase : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>The Motion Database Config sets what channels this database will use to match against (bones, trajectory and what properties of those you’re interested in, such as position and velocity).</summary>
	public UPoseSearchSchema Schema;
	///<summary>These settings allow users to trim the start and end of animations in the database to preserve start/end frames for blending, and prevent the system from selecting the very last frames before it blends out.</summary>
	public FPoseSearchExcludeFromDatabaseParameters ExcludeFromDatabaseParameters;
	///<summary>Sequences and Blendspaces are deprecated and its data will be part of the AnimationAssets.</summary>
	public TArray<FPoseSearchDatabaseSequence> Sequences_DEPRECATED;
	///<summary>BlendSpaces_DEPRECATED</summary>
	public TArray<FPoseSearchDatabaseBlendSpace> BlendSpaces_DEPRECATED;
	///<summary>If null, the default preview mesh for the skeleton will be used. Otherwise, this will be used in preview scenes.</summary>
	public USkeletalMesh PreviewMesh;
	///<summary>AnimationAssets</summary>
	public TArray<FInstancedStruct> AnimationAssets;
	///<summary>This dictates how the database will perform the search.</summary>
	public EPoseSearchMode PoseSearchMode;
	///<summary>Number of dimensions used to create the kdtree. More dimensions allows a better explanation of the variance of the dataset that usually translates in better search results, but will imply more memory usage and worse performances.</summary>
	public int NumberOfPrincipalComponents;
	///<summary>KDTreeMaxLeafSize</summary>
	public int KDTreeMaxLeafSize;
	///<summary>Out of a kdtree search, results will have only an approximate cost, so the database search will select the best “KDTree Query Num Neighbors” poses to perform the full cost analysis, and be able to elect the best pose.</summary>
	public int KDTreeQueryNumNeighbors;
	///<summary>When evaluating multiple searches, including the continuing pose search, the system keeps track of the best pose and associated cost.</summary>
	public bool bSkipSearchIfPossible;
	///<summary>This optional asset defines a list of databases you want to normalize together. Without it, it would be difficult to compare costs from separately normalized databases containing different types of animation,</summary>
	public UPoseSearchNormalizationSet NormalizationSet;
}
