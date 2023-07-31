#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component that allows you to render specified point cloud section</summary>
[CppInclude("LidarPointCloudComponent.h")]
public partial class ULidarPointCloudComponent : UMeshComponent {
	///<summary>PointCloud</summary>
	public ULidarPointCloud PointCloud;
	///<summary>Allows using custom-built material for the point cloud.</summary>
	public UMaterialInterface CustomMaterial;
	///<summary>Use to tweak the size of the points.</summary>
	public float PointSize;
	///<summary>Determines how the points will be scaled</summary>
	public ELidarPointCloudScalingMethod ScalingMethod;
	///<summary>If set to &gt; 0, it attempts to close gaps between points.</summary>
	public float GapFillingStrength;
	///<summary>Specifies which source to use for point colors.</summary>
	public ELidarPointCloudColorationMode ColorSource;
	///<summary>Affects the shape of points.</summary>
	public ELidarPointCloudSpriteShape PointShape;
	///<summary>Affects the orientation of points.</summary>
	public ELidarPointCloudSpriteOrientation PointOrientation;
	///<summary>Used with the Classification source.</summary>
	public TMap<int,FLinearColor> ClassificationColors;
	///<summary>Specifies the bottom color of the elevation-based gradient.</summary>
	public FLinearColor ElevationColorBottom;
	///<summary>Specifies the top color of the elevation-based gradient.</summary>
	public FLinearColor ElevationColorTop;
	///<summary>Larger values will help mask LOD transition areas, but too large values will lead to loss of detail.</summary>
	public float PointSizeBias;
	///<summary>Saturation</summary>
	public FVector4 Saturation;
	///<summary>Contrast</summary>
	public FVector4 Contrast;
	///<summary>Gamma</summary>
	public FVector4 Gamma;
	///<summary>Affects the emissive strength of the color. Useful to create Bloom and light bleed effects.</summary>
	public FVector4 Gain;
	///<summary>Applied additively, 0 being neutral.</summary>
	public FVector4 Offset;
	///<summary>Specifies the tint to apply to the points.</summary>
	public FLinearColor ColorTint;
	///<summary>Specifies the influence of Intensity data, if available, on the overall color.</summary>
	public float IntensityInfluence;
	///<summary>If enabled, points outside of the visible frustum will not be rendered.</summary>
	public bool bUseFrustumCulling;
	///<summary>Minimum Depth from which the nodes should be rendered.</summary>
	public int MinDepth;
	///<summary>Maximum Depth to which the nodes should be rendered.</summary>
	public int MaxDepth;
	///<summary>Enabling this will cause the visible nodes to render their bounds.</summary>
	public bool bDrawNodeBounds;
	///<summary>Material</summary>
	public UMaterialInterface Material;
	///<summary>BaseMaterial</summary>
	public UMaterialInterface BaseMaterial;
	///<summary>BaseMaterialMasked</summary>
	public UMaterialInterface BaseMaterialMasked;
	///<summary>GetPointCloud</summary>
	public  ULidarPointCloud GetPointCloud() { return default; }
	///<summary>Returns true if there are any points within the given sphere.</summary>
	public  bool HasPointsInSphere(FVector Center,float Radius,bool bVisibleOnly) { return default; }
	///<summary>Returns true if there are any points within the given box.</summary>
	public  bool HasPointsInBox(FVector Center,FVector Extent,bool bVisibleOnly) { return default; }
	///<summary>Returns true if there are any points hit by the given ray.</summary>
	public  bool HasPointsByRay(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) { return default; }
	///<summary>Populates the array with copies of points within the given sphere.</summary>
	public  TArray<FLidarPointCloudPoint> GetPointsInSphereAsCopies(FVector Center,float Radius,bool bVisibleOnly,bool bReturnWorldSpace) { return default; }
	///<summary>Populates the array with copies of points within the given box.</summary>
	public  TArray<FLidarPointCloudPoint> GetPointsInBoxAsCopies(FVector Center,FVector Extent,bool bVisibleOnly,bool bReturnWorldSpace) { return default; }
	///<summary>Performs a raycast test against the point cloud. Returns the pointer if hit or nullptr otherwise.</summary>
	public  bool LineTraceSingle(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,FLidarPointCloudPoint PointHit) { return default; }
	///<summary>Performs a raycast test against the point cloud.</summary>
	public  bool LineTraceMulti(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,bool bReturnWorldSpace,TArray<FLidarPointCloudPoint> OutHits) { return default; }
	///<summary>Sets visibility of points within the given sphere.</summary>
	public  void SetVisibilityOfPointsInSphere(bool bNewVisibility,FVector Center,float Radius) {}
	///<summary>Sets visibility of points within the given box.</summary>
	public  void SetVisibilityOfPointsInBox(bool bNewVisibility,FVector Center,FVector Extent) {}
	///<summary>Sets visibility of the first point hit by the given ray.</summary>
	public  void SetVisibilityOfFirstPointByRay(bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	///<summary>Sets visibility of points hit by the given ray.</summary>
	public  void SetVisibilityOfPointsByRay(bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	///<summary>Applies the given color to all points within the sphere</summary>
	public  void ApplyColorToPointsInSphere(FColor NewColor,FVector Center,float Radius,bool bVisibleOnly) {}
	///<summary>Applies the given color to all points within the box</summary>
	public  void ApplyColorToPointsInBox(FColor NewColor,FVector Center,FVector Extent,bool bVisibleOnly) {}
	///<summary>Applies the given color to the first point hit by the given ray</summary>
	public  void ApplyColorToFirstPointByRay(FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	///<summary>Applies the given color to all points hit by the given ray</summary>
	public  void ApplyColorToPointsByRay(FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	///<summary>Removes all points within the given sphere</summary>
	public  void RemovePointsInSphere(FVector Center,float Radius,bool bVisibleOnly) {}
	///<summary>Removes all points within the given box</summary>
	public  void RemovePointsInBox(FVector Center,FVector Extent,bool bVisibleOnly) {}
	///<summary>Removes the first point hit by the given ray</summary>
	public  void RemoveFirstPointByRay(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	///<summary>Removes all points hit by the given ray</summary>
	public  void RemovePointsByRay(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	///<summary>SetPointCloud</summary>
	public  void SetPointCloud(ULidarPointCloud InPointCloud) {}
	///<summary>Returns the current Point Shape</summary>
	public  ELidarPointCloudSpriteShape GetPointShape() { return default; }
	///<summary>Sets new Point Shape</summary>
	public  void SetPointShape(ELidarPointCloudSpriteShape NewPointShape) {}
	///<summary>Applies specified rendering parameters (Brightness, Saturation, etc) to the selected material</summary>
	public  void ApplyRenderingParameters() {}
}
