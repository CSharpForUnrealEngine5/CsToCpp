namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the Point Cloud asset</summary>
[CppInclude("LidarPointCloud.h")]
public partial class ULidarPointCloud : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Stores the path to the original source file. Empty if dynamically created.</summary>
	public FFilePath SourcePath;
	///<summary>Determines the maximum error (in cm) of the collision for this point cloud.</summary>
	public float MaxCollisionError;
	///<summary>CollisionAccuracy_DEPRECATED</summary>
	public float CollisionAccuracy_DEPRECATED;
	///<summary>Higher values will generally result in more accurate calculations, at the expense of time</summary>
	public int NormalsQuality;
	///<summary>Higher values are less susceptible to noise, but will most likely lose finer details, especially around hard edges.</summary>
	public float NormalsNoiseTolerance;
	///<summary>Stores the original offset as a double.</summary>
	public FVector OriginalCoordinates;
	///<summary>Disables the LOD pipeline, allowing for much faster data operations (insert/remove/set)</summary>
	public bool bOptimizedForDynamicData;
	///<summary>Contains an offset to be added to all points when rendering</summary>
	public FVector LocationOffset;
	///<summary>Contains the list of imported classification IDs</summary>
	public TArray<byte> ClassificationsImported;
	///<summary>Description of collision</summary>
	public UBodySetup BodySetup;
	///<summary>NewBodySetup</summary>
	public UBodySetup NewBodySetup;
	///<summary>End UObject Interface.</summary>
	public int GetNumLODs() { return default; }
	///<summary>GetNumPoints</summary>
	public long GetNumPoints() { return default; }
	///<summary>GetNumVisiblePoints</summary>
	public long GetNumVisiblePoints() { return default; }
	///<summary>GetNumNodes</summary>
	public int GetNumNodes() { return default; }
	///<summary>GetEstimatedPointSpacing</summary>
	public float GetEstimatedPointSpacing() { return default; }
	///<summary>Returns the amount of memory in MB used to store the point cloud.</summary>
	public int GetDataSize() { return default; }
	///<summary>GetSourcePath</summary>
	public string GetSourcePath() { return default; }
	///<summary>IsOptimizedForDynamicData</summary>
	public bool IsOptimizedForDynamicData() { return default; }
	///<summary>GetBounds</summary>
	public FBox GetBounds(bool bUseOriginalCoordinates/*=false*/) { return default; }
	///<summary>Recalculates and updates points bounds.</summary>
	public void RefreshBounds() {}
	///<summary>Returns true, if the Octree has collision built</summary>
	public bool HasCollisionData() { return default; }
	///<summary>Returns the number of polygons in the collider or 0 if no collider is built</summary>
	public int GetColliderPolys() { return default; }
	///<summary>RefreshRendering</summary>
	public void RefreshRendering() {}
	///<summary>Returns true if there are any points within the given sphere.</summary>
	public bool HasPointsInSphere(FVector Center,float Radius,bool bVisibleOnly) { return default; }
	///<summary>Returns true if there are any points within the given box.</summary>
	public bool HasPointsInBox(FVector Center,FVector Extent,bool bVisibleOnly) { return default; }
	///<summary>Returns true if there are any points hit by the given ray.</summary>
	public bool HasPointsByRay(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) { return default; }
	///<summary>Returns an array with copies of points from the tree</summary>
	public TArray<FLidarPointCloudPoint> GetPointsAsCopies(bool bReturnWorldSpace,int StartIndex/*=0*/,int Count/*=-1*/) { return default; }
	///<summary>Returns an array with copies of points within the given sphere</summary>
	public TArray<FLidarPointCloudPoint> GetPointsInSphereAsCopies(FVector Center,float Radius,bool bVisibleOnly,bool bReturnWorldSpace) { return default; }
	///<summary>Returns an array with copies of points within the given box</summary>
	public TArray<FLidarPointCloudPoint> GetPointsInBoxAsCopies(FVector Center,FVector Extent,bool bVisibleOnly,bool bReturnWorldSpace) { return default; }
	///<summary>Performs a raycast test against the point cloud. Returns the pointer if hit or nullptr otherwise.</summary>
	public bool LineTraceSingle(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,FLidarPointCloudPoint PointHit) { return default; }
	///<summary>Performs a raycast test against the point cloud.</summary>
	public bool LineTraceMulti(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,bool bReturnWorldSpace,TArray<FLidarPointCloudPoint> OutHits) { return default; }
	///<summary>Sets visibility of points within the given sphere.</summary>
	public void SetVisibilityOfPointsInSphere(bool bNewVisibility,FVector Center,float Radius) {}
	///<summary>Sets visibility of points within the given box.</summary>
	public void SetVisibilityOfPointsInBox(bool bNewVisibility,FVector Center,FVector Extent) {}
	///<summary>Sets visibility of the first point hit by the given ray.</summary>
	public void SetVisibilityOfFirstPointByRay(bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	///<summary>Sets visibility of points hit by the given ray.</summary>
	public void SetVisibilityOfPointsByRay(bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	///<summary>Marks all points hidden</summary>
	public void HideAll() {}
	///<summary>Marks all points visible</summary>
	public void UnhideAll() {}
	///<summary>Applies the given color to all points</summary>
	public void ApplyColorToAllPoints(FColor NewColor,bool bVisibleOnly) {}
	///<summary>Applies the given color to all points within the sphere</summary>
	public void ApplyColorToPointsInSphere(FColor NewColor,FVector Center,float Radius,bool bVisibleOnly) {}
	///<summary>Applies the given color to all points within the box</summary>
	public void ApplyColorToPointsInBox(FColor NewColor,FVector Center,FVector Extent,bool bVisibleOnly) {}
	///<summary>Applies the given color to the first point hit by the given ray</summary>
	public void ApplyColorToFirstPointByRay(FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	///<summary>Applies the given color to all points hit by the given ray</summary>
	public void ApplyColorToPointsByRay(FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	///<summary>This should to be called if any manual modification to individual points&#39; visibility has been made.</summary>
	public void MarkPointVisibilityDirty() {}
	///<summary>SetSourcePath</summary>
	public void SetSourcePath(string NewSourcePath) {}
	///<summary>SetOptimizedForDynamicData</summary>
	public void SetOptimizedForDynamicData(bool bNewOptimizedForDynamicData) {}
	///<summary>Re-initializes the asset with new bounds.</summary>
	public void Initialize(FBox NewBounds) {}
	///<summary>SetOptimalCollisionError</summary>
	public void SetOptimalCollisionError() {}
	///<summary>Builds collision mesh for the cloud, using current collision settings</summary>
	public void BuildCollision() {}
	///<summary>BuildCollisionWithCallback</summary>
	public void BuildCollisionWithCallback(UObject WorldContextObject,FLatentActionInfo LatentInfo,bool bSuccess) {}
	///<summary>Removes collision mesh from the cloud.</summary>
	public void RemoveCollision() {}
	///<summary>Returns true, if the cloud is fully and persistently loaded.</summary>
	public bool IsFullyLoaded() { return default; }
	///<summary>Persistently loads all nodes.</summary>
	public void LoadAllNodes() {}
	///<summary>Applies given offset to this point cloud.</summary>
	public void SetLocationOffset(FVector Offset) {}
	///<summary>Centers this cloud</summary>
	public void CenterPoints() {}
	///<summary>Restores original coordinates</summary>
	public void RestoreOriginalCoordinates() {}
	///<summary>Returns true, if the cloud has been centered.</summary>
	public bool IsCentered() { return default; }
	///<summary>Re-imports the cloud from it&#39;s original source file, overwriting any current point information.</summary>
	public void Reimport(UObject WorldContextObject,bool bUseAsync,FLatentActionInfo LatentInfo,ELidarPointCloudAsyncMode AsyncMode,float Progress) {}
	///<summary>Exports this Point Cloud to the given filename.</summary>
	public bool Export(string Filename) { return default; }
	///<summary>Inserts the given point into the Octree structure.</summary>
	public void InsertPoint(FLidarPointCloudPoint Point,ELidarPointCloudDuplicateHandling DuplicateHandling,bool bRefreshPointsBounds,FVector Translation) {}
	///<summary>Inserts group of points into the Octree structure, multi-threaded.</summary>
	public void InsertPoints(TArray<FLidarPointCloudPoint> Points,ELidarPointCloudDuplicateHandling DuplicateHandling,bool bRefreshPointsBounds,FVector Translation) {}
	///<summary>Attempts to remove the given point.</summary>
	public void RemovePoint(FLidarPointCloudPoint Point) {}
	///<summary>Removes all points within the given sphere</summary>
	public void RemovePointsInSphere(FVector Center,float Radius,bool bVisibleOnly) {}
	///<summary>Removes all points within the given box</summary>
	public void RemovePointsInBox(FVector Center,FVector Extent,bool bVisibleOnly) {}
	///<summary>Removes the first point hit by the given ray</summary>
	public void RemoveFirstPointByRay(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	///<summary>Removes all points hit by the given ray</summary>
	public void RemovePointsByRay(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	///<summary>Removes all hidden points</summary>
	public void RemoveHiddenPoints() {}
	///<summary>Reinitializes the cloud with the new set of data.</summary>
	public bool SetData(TArray<FLidarPointCloudPoint> Points) { return default; }
	///<summary>Merges this point cloud with the ones provided</summary>
	public void Merge(TArray<ULidarPointCloud> PointCloudsToMerge) {}
	///<summary>Merges this point cloud with the one provided</summary>
	public void MergeSingle(ULidarPointCloud PointCloudToMerge) {}
	///<summary>Calculates Normals for this point cloud</summary>
	public void CalculateNormals(FLatentActionInfo LatentInfo) {}
}
