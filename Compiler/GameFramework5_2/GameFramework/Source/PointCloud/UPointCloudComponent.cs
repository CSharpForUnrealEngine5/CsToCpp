#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PointCloudComponent.h")]
///<summary>Component for rendering a point cloud</summary>
public partial class UPointCloudComponent : UMeshComponent {
// PointCloudComponent
	public bool bIsVisible;
	public float PointCloudUpdateInterval;
	public void SetIsVisible(bool bNewVisibility) {}
	public TArray<FVector> PointCloud;
	public TArray<FColor> PointColors;
	public void SetPointCloud(TArray<FVector> Points) {}
	public void SetPointCloudWithColors(TArray<FVector> Points,TArray<FColor> Colors) {}
	public void ClearPointCloud() {}
	public FLinearColor PointColor;
	public void SetPointColor(FLinearColor Color) {}
	public float PointSize;
	public void SetPointSize(float Size) {}
	public TArray<FVector> GetPointsInBox(FBox WorldSpaceBox) { return default; }
	public TArray<FVector> GetPointsOutsideBox(FBox WorldSpaceBox) { return default; }
	public UMaterialInterface PointCloudMaterial;
	public UTexture SpriteTexture;
	public FBoxSphereBounds WorldBounds;
}
