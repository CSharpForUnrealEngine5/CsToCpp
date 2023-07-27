#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloud.h")]
///<summary>Represents the Point Cloud asset</summary>
public partial class ULidarPointCloud : UObject {
// LidarPointCloud
	public FFilePath SourcePath;
	public float MaxCollisionError;
	public float CollisionAccuracy_DEPRECATED;
	public int NormalsQuality;
	public float NormalsNoiseTolerance;
	public FVector OriginalCoordinates;
	public bool bOptimizedForDynamicData;
	public FVector LocationOffset;
	public TArray<byte> ClassificationsImported;
	public UBodySetup BodySetup;
	public UBodySetup NewBodySetup;
	public  int GetNumLODs() { return default; }
	public  long GetNumPoints() { return default; }
	public  long GetNumVisiblePoints() { return default; }
	public  int GetNumNodes() { return default; }
	public  float GetEstimatedPointSpacing() { return default; }
	public  int GetDataSize() { return default; }
	public  string GetSourcePath() { return default; }
	public  bool IsOptimizedForDynamicData() { return default; }
	public  FBox GetBounds(bool bUseOriginalCoordinates/*=false*/) { return default; }
	public  void RefreshBounds() {}
	public  bool HasCollisionData() { return default; }
	public  int GetColliderPolys() { return default; }
	public  void RefreshRendering() {}
	public  bool HasPointsInSphere(FVector Center,float Radius,bool bVisibleOnly) { return default; }
	public  bool HasPointsInBox(FVector Center,FVector Extent,bool bVisibleOnly) { return default; }
	public  bool HasPointsByRay(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) { return default; }
	public  TArray<FLidarPointCloudPoint> GetPointsAsCopies(bool bReturnWorldSpace,int StartIndex/*=0*/,int Count/*=-1*/) { return default; }
	public  TArray<FLidarPointCloudPoint> GetPointsInSphereAsCopies(FVector Center,float Radius,bool bVisibleOnly,bool bReturnWorldSpace) { return default; }
	public  TArray<FLidarPointCloudPoint> GetPointsInBoxAsCopies(FVector Center,FVector Extent,bool bVisibleOnly,bool bReturnWorldSpace) { return default; }
	public  bool LineTraceSingle(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,FLidarPointCloudPoint PointHit) { return default; }
	public  bool LineTraceMulti(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,bool bReturnWorldSpace,TArray<FLidarPointCloudPoint> OutHits) { return default; }
	public  void SetVisibilityOfPointsInSphere(bool bNewVisibility,FVector Center,float Radius) {}
	public  void SetVisibilityOfPointsInBox(bool bNewVisibility,FVector Center,FVector Extent) {}
	public  void SetVisibilityOfFirstPointByRay(bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	public  void SetVisibilityOfPointsByRay(bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	public  void HideAll() {}
	public  void UnhideAll() {}
	public  void ApplyColorToAllPoints(FColor NewColor,bool bVisibleOnly) {}
	public  void ApplyColorToPointsInSphere(FColor NewColor,FVector Center,float Radius,bool bVisibleOnly) {}
	public  void ApplyColorToPointsInBox(FColor NewColor,FVector Center,FVector Extent,bool bVisibleOnly) {}
	public  void ApplyColorToFirstPointByRay(FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public  void ApplyColorToPointsByRay(FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public  void MarkPointVisibilityDirty() {}
	public  void SetSourcePath(string NewSourcePath) {}
	public  void SetOptimizedForDynamicData(bool bNewOptimizedForDynamicData) {}
	public  void Initialize(FBox NewBounds) {}
	public  void SetOptimalCollisionError() {}
	public  void BuildCollision() {}
	public  void BuildCollisionWithCallback(UObject WorldContextObject,FLatentActionInfo LatentInfo,bool bSuccess) {}
	public  void RemoveCollision() {}
	public  bool IsFullyLoaded() { return default; }
	public  void LoadAllNodes() {}
	public  void SetLocationOffset(FVector Offset) {}
	public  void CenterPoints() {}
	public  void RestoreOriginalCoordinates() {}
	public  bool IsCentered() { return default; }
	public  void Reimport(UObject WorldContextObject,bool bUseAsync,FLatentActionInfo LatentInfo,ELidarPointCloudAsyncMode AsyncMode,float Progress) {}
	public  bool Export(string Filename) { return default; }
	public  void InsertPoint(FLidarPointCloudPoint Point,ELidarPointCloudDuplicateHandling DuplicateHandling,bool bRefreshPointsBounds,FVector Translation) {}
	public  void InsertPoints(TArray<FLidarPointCloudPoint> Points,ELidarPointCloudDuplicateHandling DuplicateHandling,bool bRefreshPointsBounds,FVector Translation) {}
	public  void RemovePoint(FLidarPointCloudPoint Point) {}
	public  void RemovePointsInSphere(FVector Center,float Radius,bool bVisibleOnly) {}
	public  void RemovePointsInBox(FVector Center,FVector Extent,bool bVisibleOnly) {}
	public  void RemoveFirstPointByRay(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public  void RemovePointsByRay(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public  void RemoveHiddenPoints() {}
	public  bool SetData(TArray<FLidarPointCloudPoint> Points) { return default; }
	public  void Merge(TArray<ULidarPointCloud> PointCloudsToMerge) {}
	public  void MergeSingle(ULidarPointCloud PointCloudToMerge) {}
	public  void CalculateNormals(FLatentActionInfo LatentInfo) {}
}
