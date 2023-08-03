#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component for rendering a point cloud</summary>
[CppInclude("PointCloudComponent.h")]
public partial class UPointCloudComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>If true, each tick the component will render its point cloud</summary>
	public bool bIsVisible;
	///<summary>If &gt; 0, will automatically update the point cloud data from AR system based on this interval (sec)</summary>
	public float PointCloudUpdateInterval;
	///<summary>Changes the visibility setting</summary>
	public  void SetIsVisible(bool bNewVisibility) {}
	///<summary>Point cloud data that will be used for rendering, assumes each point is in world space</summary>
	public TArray<FVector> PointCloud;
	///<summary>Point cloud color data that will be used for rendering</summary>
	public TArray<FColor> PointColors;
	///<summary>Updates the point cloud data with the new set of points</summary>
	public  void SetPointCloud(TArray<FVector> Points) {}
	///<summary>Updates the point cloud data with the new set of points and colors</summary>
	public  void SetPointCloudWithColors(TArray<FVector> Points,TArray<FColor> Colors) {}
	///<summary>Empties the point cloud</summary>
	public  void ClearPointCloud() {}
	///<summary>The color to render the points with</summary>
	public FLinearColor PointColor;
	///<summary>Allows you to change the color of the points being rendered</summary>
	public  void SetPointColor(FLinearColor Color) {}
	///<summary>The size of the point when rendering</summary>
	public float PointSize;
	///<summary>Allows you to change the size of the points being rendered</summary>
	public  void SetPointSize(float Size) {}
	///<summary>Determines which points are within the box and returns those to the caller</summary>
	public  TArray<FVector> GetPointsInBox(FBox WorldSpaceBox) { return default; }
	///<summary>Determines which points are outside the box and returns those to the caller</summary>
	public  TArray<FVector> GetPointsOutsideBox(FBox WorldSpaceBox) { return default; }
	///<summary>The material to render with</summary>
	public UMaterialInterface PointCloudMaterial;
	///<summary>An optional sprite texture to render the point with</summary>
	public UTexture SpriteTexture;
	///<summary>World space bounds of the point cloud</summary>
	public FBoxSphereBounds WorldBounds;
}
