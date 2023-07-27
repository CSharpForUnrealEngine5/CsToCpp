#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloud.h")]
///<summary>Blueprint library for the Point Cloud assets</summary>
public partial class ULidarPointCloudBlueprintLibrary : UBlueprintFunctionLibrary {
// LidarPointCloudBlueprintLibrary
	public static ULidarPointCloud CreatePointCloudEmpty() { return default; }
	public static void CreatePointCloudFromFile(UObject WorldContextObject,string Filename,bool bUseAsync,FLatentActionInfo LatentInfo,ELidarPointCloudAsyncMode AsyncMode,float Progress,ULidarPointCloud PointCloud) {}
	public static void CreatePointCloudFromData(UObject WorldContextObject,TArray<FLidarPointCloudPoint> Points,bool bUseAsync,FLatentActionInfo LatentInfo,ELidarPointCloudAsyncMode AsyncMode,float Progress,ULidarPointCloud PointCloud) {}
	public static bool ExportPointCloudToFile(ULidarPointCloud PointCloud,string Filename) { return default; }
	public static void AlignClouds(TArray<ULidarPointCloud> PointCloudsToAlign) {}
	public static bool ArePointsInSphere(UObject WorldContextObject,FVector Center,float Radius,bool bVisibleOnly) { return default; }
	public static bool ArePointsInBox(UObject WorldContextObject,FVector Center,FVector Extent,bool bVisibleOnly) { return default; }
	public static bool ArePointsByRay(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) { return default; }
	public static void GetPointsInSphereAsCopies(UObject WorldContextObject,TArray<FLidarPointCloudPoint> SelectedPoints,FVector Center,float Radius,bool bVisibleOnly) {}
	public static void GetPointsInBoxAsCopies(UObject WorldContextObject,TArray<FLidarPointCloudPoint> SelectedPoints,FVector Center,FVector Extent,bool bVisibleOnly) {}
	public static bool LineTraceSingle(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,FLidarPointCloudTraceHit Hit) { return default; }
	public static bool LineTraceMulti(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,TArray<FLidarPointCloudTraceHit> Hits) { return default; }
	public static void SetVisibilityOfPointsInSphere(UObject WorldContextObject,bool bNewVisibility,FVector Center,float Radius) {}
	public static void SetVisibilityOfPointsInBox(UObject WorldContextObject,bool bNewVisibility,FVector Center,FVector Extent) {}
	public static void SetVisibilityOfFirstPointByRay(UObject WorldContextObject,bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	public static void SetVisibilityOfPointsByRay(UObject WorldContextObject,bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	public static void ApplyColorToPointsInSphere(UObject WorldContextObject,FColor NewColor,FVector Center,float Radius,bool bVisibleOnly) {}
	public static void ApplyColorToPointsInBox(UObject WorldContextObject,FColor NewColor,FVector Center,FVector Extent,bool bVisibleOnly) {}
	public static void ApplyColorToFirstPointByRay(UObject WorldContextObject,FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public static void ApplyColorToPointsByRay(UObject WorldContextObject,FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public static void RemovePointsInSphere(UObject WorldContextObject,FVector Center,float Radius,bool bVisibleOnly) {}
	public static void RemovePointsInBox(UObject WorldContextObject,FVector Center,FVector Extent,bool bVisibleOnly) {}
	public static void RemoveFirstPointByRay(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public static void RemovePointsByRay(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public static void NormalFromVector(FLidarPointCloudNormal Normal,FVector Vector) {}
	public static FVector Conv_LidarPointCloudNormalToVector(FLidarPointCloudNormal Normal) { return default; }
	public static FLidarPointCloudNormal Conv_VectorToLidarPointCloudNormal(FVector Vector) { return default; }
}
