#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreTypes.h")]
///<summary>A UObject that contains a set of observed 3D points and confidence values.</summary>
public partial class UGoogleARCorePointCloud : UObject {
// GoogleARCorePointCloud
	public bool IsUpdated() { return default; }
	public int GetPointNum() { return default; }
	public void GetPoint(int Index,FVector OutWorldPosition,float OutConfidence) {}
	public int GetPointId(int Index) { return default; }
	public void GetPointInTrackingSpace(int Index,FVector OutTrackingSpaceLocation,float OutConfidence) {}
	public void ReleasePointCloud() {}
}
