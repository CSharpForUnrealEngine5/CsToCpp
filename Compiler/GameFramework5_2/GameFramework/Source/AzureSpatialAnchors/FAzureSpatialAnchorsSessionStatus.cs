#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsTypes.h")]
public partial struct FAzureSpatialAnchorsSessionStatus {
	public float ReadyForCreateProgress;
	public float RecommendedForCreateProgress;
	public int SessionCreateHash;
	public int SessionLocateHash;
	public EAzureSpatialAnchorsSessionUserFeedback feedback;
}
