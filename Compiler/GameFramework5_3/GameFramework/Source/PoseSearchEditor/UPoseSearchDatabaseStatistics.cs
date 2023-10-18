namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchDatabaseEditorReflection.h")]
public partial class UPoseSearchDatabaseStatistics : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Number of Animation Sequences in the database.</summary>
	public uint AnimationSequences;
	///<summary>Number of total animation poses in frames in the database.</summary>
	public uint TotalAnimationPosesInFrames;
	///<summary>Number of total animation poses in time in the database.</summary>
	public FText TotalAnimationPosesInTime;
	///<summary>Amount of animation frames that are searchable in the database (this will exclude frames that have been removed using Sampling Range).</summary>
	public uint SearchableFrames;
	///<summary>Amount of animation in time that are searchable in the database (this will exclude time that have been removed using Sampling Range).</summary>
	public FText SearchableTime;
	///<summary>Cardinality for the database config (how many floats per pose to store the pose features data)</summary>
	public uint ConfigCardinality;
	///<summary>Average speed of the characters trajectory across all animations in the database.</summary>
	public FText AverageSpeed;
	///<summary>Highest speed of the characters trajectory across all animations in the database.</summary>
	public FText MaxSpeed;
	///<summary>The average acceleration of the characters trajectory across all the animations in the database.</summary>
	public FText AverageAcceleration;
	///<summary>The max acceleration of the characters trajectory across all the animations in the database.</summary>
	public FText MaxAcceleration;
	///<summary>When Pose Search Mode is set to PCAKDTree this value represents how well the variance of the dataset is explained within the chosen Number Of Principal Components:</summary>
	public float ExplainedVariance;
	///<summary>aggregated total memory used by this database.</summary>
	public FText EstimatedDatabaseSize;
	///<summary>partial memory size used to store the pose feature vectors.</summary>
	public FText ValuesSize;
	///<summary>partial memory size used to store the pose feature vectors in PCA space.</summary>
	public FText PCAValuesSize;
	///<summary>partial memory size used by the kdtree.</summary>
	public FText KDTreeSize;
	///<summary>partial memory size used to store database metadata.</summary>
	public FText PoseMetadataSize;
	///<summary>partial memory size used to animation data sub ranges, mirror state, blend parameters.</summary>
	public FText AssetsSize;
}
