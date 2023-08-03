#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A UObject that contains a set of observed 3D points and confidence values.</summary>
[CppInclude("GoogleARCoreTypes.h")]
public partial class UGoogleARCorePointCloud : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Checks if this point cloud has been updated in this frame.</summary>
	public  bool IsUpdated() { return default; }
	///<summary>Returns the number of point inside this point cloud.</summary>
	public  int GetPointNum() { return default; }
	///<summary>Returns the point position in Unreal world space and it&#39;s confidence value from 0 ~ 1.</summary>
	public  void GetPoint(int Index,FVector OutWorldPosition,float OutConfidence) {}
	///<summary>Returns the point Id of the point at the given index.</summary>
	public  int GetPointId(int Index) { return default; }
	///<summary>Returns the point position in Unreal AR Tracking space.</summary>
	public  void GetPointInTrackingSpace(int Index,FVector OutTrackingSpaceLocation,float OutConfidence) {}
	///<summary>Release PointCloud&#39;s resources back to ArCore. Data will not be available after releasePointCloud is called.</summary>
	public  void ReleasePointCloud() {}
}
