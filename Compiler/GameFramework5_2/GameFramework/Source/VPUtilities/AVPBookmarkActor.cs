#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBookmarkActor.h")]
public partial class AVPBookmarkActor : AVPViewportTickableActorBase {
// VPBookmarkActor
	public UStaticMeshComponent BookmarkMeshComponent;
	public UTextRenderComponent NameTextRenderComponent;
	public USplineMeshComponent SplineMeshComponent;
	public UCineCameraComponent CameraComponent;
	public FLinearColor BookmarkColor;
	public UVPBookmark BookmarkObject;
	public bool IsHome;
	public UTexture2D SnapshotTexture;
	public  void UpdateBookmarkColor(FLinearColor Color) {}
	public UMaterialInstanceDynamic DynamicMaterial;
	public UMaterialInterface BookmarkMaterial;
	public  void OnBookmarkActivation_Implementation(UVPBookmark Bookmark,bool bActivate) {}
	public  void OnBookmarkChanged_Implementation(UVPBookmark Bookmark) {}
	public  void UpdateBookmarkSplineMeshIndicator_Implementation() {}
	public  void HideBookmarkSplineMeshIndicator_Implementation() {}
	public  void GenerateBookmarkName_Implementation() {}
	public  void OnActorDroppedFromCarry_Implementation() {}
	public  void OnActorSelectedForTransform_Implementation() {}
	public  void OnActorDroppedFromTransform_Implementation() {}
	public UStaticMesh BookmarkStaticMesh;
	public UMaterial TextMaterial;
	public UStaticMesh SplineStaticMesh;
	public UMaterialInterface SplineMaterial;
	public UMaterialInterface SplineMaterialInstance;
	public UMaterialInterface LabelMaterialInstance;
}
