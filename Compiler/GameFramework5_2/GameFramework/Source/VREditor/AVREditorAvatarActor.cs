#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VREditorAvatarActor.h")]
///<summary>Avatar Actor</summary>
public partial class AVREditorAvatarActor : AActor {
// VREditorAvatarActor
	public UStaticMeshComponent HeadMeshComponent;
	public UStaticMeshComponent WorldMovementGridMeshComponent;
	public UMaterialInstanceDynamic WorldMovementGridMID;
	public float WorldMovementGridOpacity;
	public bool bIsDrawingWorldMovementPostProcess;
	public UMaterialInstanceDynamic WorldMovementPostProcessMaterial;
	public UStaticMeshComponent ScaleProgressMeshComponent;
	public UStaticMeshComponent CurrentScaleProgressMeshComponent;
	public UTextRenderComponent UserScaleIndicatorText;
	public UMaterialInstanceDynamic FixedUserScaleMID;
	public UMaterialInstanceDynamic TranslucentFixedUserScaleMID;
	public UMaterialInstanceDynamic CurrentUserScaleMID;
	public UMaterialInstanceDynamic TranslucentCurrentUserScaleMID;
	public UPostProcessComponent PostProcessComponent;
	public UVREditorMode VRMode;
}
