#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
	public string TotalAnimationPosesInTime;
	///<summary>SearchableFrames</summary>
	public uint SearchableFrames;
	///<summary>SearchableTime</summary>
	public string SearchableTime;
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
	public string EstimatedDatabaseSize;
	///<summary>ValuesSize</summary>
	public string ValuesSize;
	///<summary>PCAValuesSize</summary>
	public string PCAValuesSize;
	///<summary>KDTreeSize</summary>
	public string KDTreeSize;
	///<summary>PoseMetadataSize</summary>
	public string PoseMetadataSize;
	///<summary>AssetsSize</summary>
	public string AssetsSize;
}
