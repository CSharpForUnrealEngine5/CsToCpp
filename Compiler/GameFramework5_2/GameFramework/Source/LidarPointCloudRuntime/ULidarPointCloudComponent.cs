#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloudComponent.h")]
///<summary>Component that allows you to render specified point cloud section</summary>
public partial class ULidarPointCloudComponent : UMeshComponent {
// LidarPointCloudComponent
	public ULidarPointCloud PointCloud;
	public UMaterialInterface CustomMaterial;
	public float PointSize;
	public ELidarPointCloudScalingMethod ScalingMethod;
	public float GapFillingStrength;
	public ELidarPointCloudColorationMode ColorSource;
	public ELidarPointCloudSpriteShape PointShape;
	public ELidarPointCloudSpriteOrientation PointOrientation;
	public TMap<int,FLinearColor> ClassificationColors;
	public FLinearColor ElevationColorBottom;
	public FLinearColor ElevationColorTop;
	public float PointSizeBias;
	public FVector4 Saturation;
	public FVector4 Contrast;
	public FVector4 Gamma;
	public FVector4 Gain;
	public FVector4 Offset;
	public FLinearColor ColorTint;
	public float IntensityInfluence;
	public bool bUseFrustumCulling;
	public int MinDepth;
	public int MaxDepth;
	public bool bDrawNodeBounds;
	public UMaterialInterface Material;
	public UMaterialInterface BaseMaterial;
	public UMaterialInterface BaseMaterialMasked;
	public  ULidarPointCloud GetPointCloud() { return default; }
	public  bool HasPointsInSphere(FVector Center,float Radius,bool bVisibleOnly) { return default; }
	public  bool HasPointsInBox(FVector Center,FVector Extent,bool bVisibleOnly) { return default; }
	public  bool HasPointsByRay(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) { return default; }
	public  TArray<FLidarPointCloudPoint> GetPointsInSphereAsCopies(FVector Center,float Radius,bool bVisibleOnly,bool bReturnWorldSpace) { return default; }
	public  TArray<FLidarPointCloudPoint> GetPointsInBoxAsCopies(FVector Center,FVector Extent,bool bVisibleOnly,bool bReturnWorldSpace) { return default; }
	public  bool LineTraceSingle(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,FLidarPointCloudPoint PointHit) { return default; }
	public  bool LineTraceMulti(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly,bool bReturnWorldSpace,TArray<FLidarPointCloudPoint> OutHits) { return default; }
	public  void SetVisibilityOfPointsInSphere(bool bNewVisibility,FVector Center,float Radius) {}
	public  void SetVisibilityOfPointsInBox(bool bNewVisibility,FVector Center,FVector Extent) {}
	public  void SetVisibilityOfFirstPointByRay(bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	public  void SetVisibilityOfPointsByRay(bool bNewVisibility,FVector Origin,FVector Direction,float Radius) {}
	public  void ApplyColorToPointsInSphere(FColor NewColor,FVector Center,float Radius,bool bVisibleOnly) {}
	public  void ApplyColorToPointsInBox(FColor NewColor,FVector Center,FVector Extent,bool bVisibleOnly) {}
	public  void ApplyColorToFirstPointByRay(FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public  void ApplyColorToPointsByRay(FColor NewColor,FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public  void RemovePointsInSphere(FVector Center,float Radius,bool bVisibleOnly) {}
	public  void RemovePointsInBox(FVector Center,FVector Extent,bool bVisibleOnly) {}
	public  void RemoveFirstPointByRay(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public  void RemovePointsByRay(FVector Origin,FVector Direction,float Radius,bool bVisibleOnly) {}
	public  void SetPointCloud(ULidarPointCloud InPointCloud) {}
	public  ELidarPointCloudSpriteShape GetPointShape() { return default; }
	public  void SetPointShape(ELidarPointCloudSpriteShape NewPointShape) {}
	public  void ApplyRenderingParameters() {}
}
