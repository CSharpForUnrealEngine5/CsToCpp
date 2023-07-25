#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloud.h")]
///<summary>Blueprint library for the Point Cloud assets</summary>
public partial class ULidarPointCloudBlueprintLibrary : UBlueprintFunctionLibrary {
// LidarPointCloudBlueprintLibrary
	public UObject CreatePointCloudEmpty() { return default; }
	public void CreatePointCloudFromFile(UObject WorldContextObject,string Filename,bool bUseAsync,FLatentActionInfo LatentInfo,ELidarPointCloudAsyncMode AsyncMode,float Progress,UObject PointCloud) {}
	public void CreatePointCloudFromData(UObject WorldContextObject,TArray<FLidarPointCloudPoint> Points,bool bUseAsync,FLatentActionInfo LatentInfo,ELidarPointCloudAsyncMode AsyncMode,float Progress,UObject PointCloud) {}
	public bool ExportPointCloudToFile(UObject PointCloud,string Filename) { return default; }
	public void AlignClouds(TArray<UObject> PointCloudsToAlign) {}
	public bool ArePointsInSphere(UObject WorldContextObject,FVector Center,float Radius,bool bVisibleOnly) { return default; }
	public bool ArePointsInBox(UObject WorldContextObject,FVector Center,FVector Extent,bool bVisibleOnly) { return default; }
	public bool ArePointsByRay(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) { return default; }
	public void GetPointsInSphereAsCopies(UObject WorldContextObject,TArray<FLidarPointCloudPoint> SelectedPoints,FVector Center,float Radius,bool bVisibleOnly) {}
	public void GetPointsInBoxAsCopies(UObject WorldContextObject,TArray<FLidarPointCloudPoint> SelectedPoints,FVector Center,FVector Extent,bool bVisibleOnly) {}
	public bool LineTraceSingle(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,FLidarPointCloudTraceHit Hit) { return default; }
	public bool LineTraceMulti(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,TArray<FLidarPointCloudTraceHit> Hits) { return default; }
	public void SetVisibilityOfPointsInSphere(UObject WorldContextObject,bool bNewVisibility,FVector Center,float Radius) {}
	public void SetVisibilityOfPointsInBox(UObject WorldContextObject,bool bNewVisibility,FVector Center,FVector Extent) {}
	public void SetVisibilityOfFirstPointByRay(UObject WorldContextObject,bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	public void SetVisibilityOfPointsByRay(UObject WorldContextObject,bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	public void ApplyColorToPointsInSphere(UObject WorldContextObject,FColor NewColor,FVector Center,float Radius,bool bVisibleOnly) {}
	public void ApplyColorToPointsInBox(UObject WorldContextObject,FColor NewColor,FVector Center,FVector Extent,bool bVisibleOnly) {}
	public void ApplyColorToFirstPointByRay(UObject WorldContextObject,FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public void ApplyColorToPointsByRay(UObject WorldContextObject,FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public void RemovePointsInSphere(UObject WorldContextObject,FVector Center,float Radius,bool bVisibleOnly) {}
	public void RemovePointsInBox(UObject WorldContextObject,FVector Center,FVector Extent,bool bVisibleOnly) {}
	public void RemoveFirstPointByRay(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public void RemovePointsByRay(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public void NormalFromVector(FLidarPointCloudNormal Normal,FVector Vector) {}
	public FVector Conv_LidarPointCloudNormalToVector(FLidarPointCloudNormal Normal) { return default; }
	public FLidarPointCloudNormal Conv_VectorToLidarPointCloudNormal(FVector Vector) { return default; }
}
