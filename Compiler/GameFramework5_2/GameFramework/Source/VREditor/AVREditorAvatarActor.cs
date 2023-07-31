#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Avatar Actor</summary>
[CppInclude("VREditorAvatarActor.h")]
public partial class AVREditorAvatarActor : AActor {
	///<summary>Our avatar&#39;s head mesh</summary>
	public UStaticMeshComponent HeadMeshComponent;
	///<summary>The grid that appears while the user is dragging the world around</summary>
	public UStaticMeshComponent WorldMovementGridMeshComponent;
	///<summary>Grid mesh component dynamic material instance to set the opacity</summary>
	public UMaterialInstanceDynamic WorldMovementGridMID;
	///<summary>Opacity of the movement grid and post process</summary>
	public float WorldMovementGridOpacity;
	///<summary>True if we&#39;re currently drawing our world movement post process</summary>
	public bool bIsDrawingWorldMovementPostProcess;
	///<summary>Post process material for &quot;greying out&quot; the world while in world movement mode</summary>
	public UMaterialInstanceDynamic WorldMovementPostProcessMaterial;
	///<summary>Background progressbar scaling mesh</summary>
	public UStaticMeshComponent ScaleProgressMeshComponent;
	///<summary>Current scale progressbar mesh</summary>
	public UStaticMeshComponent CurrentScaleProgressMeshComponent;
	///<summary>Current scale text</summary>
	public UTextRenderComponent UserScaleIndicatorText;
	///<summary>Base dynamic material for the user scale fixed progressbar</summary>
	public UMaterialInstanceDynamic FixedUserScaleMID;
	///<summary>Translucent dynamic material for the user scale fixed progressbar</summary>
	public UMaterialInstanceDynamic TranslucentFixedUserScaleMID;
	///<summary>Base dynamic material for the current user scale progressbar</summary>
	public UMaterialInstanceDynamic CurrentUserScaleMID;
	///<summary>Translucent dynamic material for the current user scale progressbar</summary>
	public UMaterialInstanceDynamic TranslucentCurrentUserScaleMID;
	///<summary>Post process for drawing VR-specific post effects</summary>
	public UPostProcessComponent PostProcessComponent;
	///<summary>Owning object</summary>
	public UVREditorMode VRMode;
}
