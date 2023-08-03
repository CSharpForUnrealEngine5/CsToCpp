#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint library for the Point Cloud assets</summary>
[CppInclude("LidarPointCloud.h")]
public partial class ULidarPointCloudBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns new, empty Point Cloud object.</summary>
	public static ULidarPointCloud CreatePointCloudEmpty() { return default; }
	///<summary>Returns new Point Cloud object imported using default settings.</summary>
	public static void CreatePointCloudFromFile(UObject WorldContextObject,string Filename,bool bUseAsync,FLatentActionInfo LatentInfo,ELidarPointCloudAsyncMode AsyncMode,float Progress,ULidarPointCloud PointCloud) {}
	///<summary>* Returns new Point Cloud object created from the data provided.</summary>
	public static void CreatePointCloudFromData(UObject WorldContextObject,TArray<FLidarPointCloudPoint> Points,bool bUseAsync,FLatentActionInfo LatentInfo,ELidarPointCloudAsyncMode AsyncMode,float Progress,ULidarPointCloud PointCloud) {}
	///<summary>Exports the Point Cloud to the given filename.</summary>
	public static bool ExportPointCloudToFile(ULidarPointCloud PointCloud,string Filename) { return default; }
	///<summary>Aligns provided clouds based on the relative offset between their Original Coordinates. Retains overall centering of the group.</summary>
	public static void AlignClouds(TArray<ULidarPointCloud> PointCloudsToAlign) {}
	///<summary>Returns true if there are any points within the given sphere.</summary>
	public static bool ArePointsInSphere(UObject WorldContextObject,FVector Center,float Radius,bool bVisibleOnly) { return default; }
	///<summary>Returns true if there are any points within the given box.</summary>
	public static bool ArePointsInBox(UObject WorldContextObject,FVector Center,FVector Extent,bool bVisibleOnly) { return default; }
	///<summary>Returns true if there are any points hit by the given ray.</summary>
	public static bool ArePointsByRay(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) { return default; }
	///<summary>Returns an array with copies of points within the given sphere</summary>
	public static void GetPointsInSphereAsCopies(UObject WorldContextObject,TArray<FLidarPointCloudPoint> SelectedPoints,FVector Center,float Radius,bool bVisibleOnly) {}
	///<summary>Returns an array with copies of points within the given box</summary>
	public static void GetPointsInBoxAsCopies(UObject WorldContextObject,TArray<FLidarPointCloudPoint> SelectedPoints,FVector Center,FVector Extent,bool bVisibleOnly) {}
	///<summary>Does a collision trace along the given line and returns the first blocking hit encountered.</summary>
	public static bool LineTraceSingle(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,FLidarPointCloudTraceHit Hit) { return default; }
	///<summary>Does a collision trace along the given line and returns all hits encountered up to and including the first blocking hit.</summary>
	public static bool LineTraceMulti(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,TArray<FLidarPointCloudTraceHit> Hits) { return default; }
	///<summary>Sets visibility of points within the given sphere.</summary>
	public static void SetVisibilityOfPointsInSphere(UObject WorldContextObject,bool bNewVisibility,FVector Center,float Radius) {}
	///<summary>Sets visibility of points within the given box.</summary>
	public static void SetVisibilityOfPointsInBox(UObject WorldContextObject,bool bNewVisibility,FVector Center,FVector Extent) {}
	///<summary>Sets visibility of the first point hit by the given ray.</summary>
	public static void SetVisibilityOfFirstPointByRay(UObject WorldContextObject,bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	///<summary>Sets visibility of points hit by the given ray.</summary>
	public static void SetVisibilityOfPointsByRay(UObject WorldContextObject,bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	///<summary>Applies the given color to all points within the sphere</summary>
	public static void ApplyColorToPointsInSphere(UObject WorldContextObject,FColor NewColor,FVector Center,float Radius,bool bVisibleOnly) {}
	///<summary>Applies the given color to all points within the box</summary>
	public static void ApplyColorToPointsInBox(UObject WorldContextObject,FColor NewColor,FVector Center,FVector Extent,bool bVisibleOnly) {}
	///<summary>Applies the given color to the first point hit by the given ray</summary>
	public static void ApplyColorToFirstPointByRay(UObject WorldContextObject,FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	///<summary>Applies the given color to all points hit by the given ray</summary>
	public static void ApplyColorToPointsByRay(UObject WorldContextObject,FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	///<summary>Removes all points within the given sphere</summary>
	public static void RemovePointsInSphere(UObject WorldContextObject,FVector Center,float Radius,bool bVisibleOnly) {}
	///<summary>Removes all points within the given box</summary>
	public static void RemovePointsInBox(UObject WorldContextObject,FVector Center,FVector Extent,bool bVisibleOnly) {}
	///<summary>Removes the first point hit by the given ray</summary>
	public static void RemoveFirstPointByRay(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	///<summary>Removes all points hit by the given ray</summary>
	public static void RemovePointsByRay(UObject WorldContextObject,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	///<summary>Sets the given normal using provided vector</summary>
	public static void NormalFromVector(FLidarPointCloudNormal Normal,FVector Vector) {}
	///<summary>Converts a Lidar Point Cloud Normal to a Vector</summary>
	public static FVector Conv_LidarPointCloudNormalToVector(FLidarPointCloudNormal Normal) { return default; }
	///<summary>Converts a Vector to a Lidar Point Cloud Normal</summary>
	public static FLidarPointCloudNormal Conv_VectorToLidarPointCloudNormal(FVector Vector) { return default; }
}
