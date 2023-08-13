namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBookmarkActor.h")]
public partial class AVPBookmarkActor : AVPViewportTickableActorBase {
	public static UClass StaticClass() {return default;}
	///<summary>Mesh Representation in the world</summary>
	public UStaticMeshComponent BookmarkMeshComponent;
	///<summary>Textrender to display bookmark name</summary>
	public UTextRenderComponent NameTextRenderComponent;
	///<summary>Splinemesh</summary>
	public USplineMeshComponent SplineMeshComponent;
	///<summary>CineCamera</summary>
	public UCineCameraComponent CameraComponent;
	///<summary>Color of Bookmark in MU Session</summary>
	public FLinearColor BookmarkColor;
	///<summary>Reference to Editor Bookmark UObject</summary>
	public UVPBookmark BookmarkObject;
	///<summary>Bool to determine if this bookmark should be designated the home location</summary>
	public bool IsHome;
	///<summary>Texture reference to store render of viewpoint</summary>
	public UTexture2D SnapshotTexture;
	///<summary>Update the mesh color and BookmarkColor variable. Intended for use with multiuser initialization</summary>
	public void UpdateBookmarkColor(FLinearColor Color) {}
	///<summary>DynamicMaterial</summary>
	public UMaterialInstanceDynamic DynamicMaterial;
	///<summary>BookmarkMaterial</summary>
	public UMaterialInterface BookmarkMaterial;
	///<summary>VPBookmark Interface events</summary>
	public void OnBookmarkActivation_Implementation(UVPBookmark Bookmark,bool bActivate) {}
	///<summary>OnBookmarkChanged_Implementation</summary>
	public void OnBookmarkChanged_Implementation(UVPBookmark Bookmark) {}
	///<summary>UpdateBookmarkSplineMeshIndicator_Implementation</summary>
	public void UpdateBookmarkSplineMeshIndicator_Implementation() {}
	///<summary>HideBookmarkSplineMeshIndicator_Implementation</summary>
	public void HideBookmarkSplineMeshIndicator_Implementation() {}
	///<summary>GenerateBookmarkName_Implementation</summary>
	public void GenerateBookmarkName_Implementation() {}
	///<summary>VPInteraction Interface Events</summary>
	public void OnActorDroppedFromCarry_Implementation() {}
	///<summary>OnActorSelectedForTransform_Implementation</summary>
	public void OnActorSelectedForTransform_Implementation() {}
	///<summary>OnActorDroppedFromTransform_Implementation</summary>
	public void OnActorDroppedFromTransform_Implementation() {}
	///<summary>Actor&#39;s rotation</summary>
	public UStaticMesh BookmarkStaticMesh;
	///<summary>Mesh to use main static mesh component</summary>
	public UMaterial TextMaterial;
	///<summary>SplineStaticMesh</summary>
	public UStaticMesh SplineStaticMesh;
	///<summary>SplineMaterial</summary>
	public UMaterialInterface SplineMaterial;
	///<summary>SplineMaterialInstance</summary>
	public UMaterialInterface SplineMaterialInstance;
	///<summary>LabelMaterialInstance</summary>
	public UMaterialInterface LabelMaterialInstance;
}
