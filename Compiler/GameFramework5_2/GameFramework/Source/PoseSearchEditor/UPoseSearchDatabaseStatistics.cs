namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchDatabaseEditorReflection.h")]
public partial class UPoseSearchDatabaseStatistics : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>General information</summary>
	public uint AnimationSequences;
	///<summary>TotalAnimationPosesInFrames</summary>
	public uint TotalAnimationPosesInFrames;
	///<summary>TotalAnimationPosesInTime</summary>
	public FText TotalAnimationPosesInTime;
	///<summary>SearchableFrames</summary>
	public uint SearchableFrames;
	///<summary>SearchableTime</summary>
	public FText SearchableTime;
	///<summary>Velocity Information</summary>
	public double AverageVelocity;
	///<summary>MaxVelocity</summary>
	public double MaxVelocity;
	///<summary>AverageAcceleration</summary>
	public double AverageAcceleration;
	///<summary>MaxAcceleration</summary>
	public double MaxAcceleration;
	///<summary>Principal Component Analysis (PCA) Information</summary>
	public float ExplainedVariance;
	///<summary>Memory information</summary>
	public FText EstimatedDatabaseSize;
	///<summary>ValuesSize</summary>
	public FText ValuesSize;
	///<summary>PCAValuesSize</summary>
	public FText PCAValuesSize;
	///<summary>KDTreeSize</summary>
	public FText KDTreeSize;
	///<summary>PoseMetadataSize</summary>
	public FText PoseMetadataSize;
	///<summary>AssetsSize</summary>
	public FText AssetsSize;
}
