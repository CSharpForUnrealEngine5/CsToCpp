#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>VR Editor interaction with the 3D world</summary>
[CppInclude("VREditorPlacement.h")]
public partial class UVREditorPlacement : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Owning object</summary>
	public UVREditorMode VRMode;
	///<summary>The actual ViewportWorldInteraction</summary>
	public UViewportWorldInteraction ViewportWorldInteraction;
	///<summary>The UI used to drag an asset into the level</summary>
	public UWidgetComponent FloatingUIAssetDraggedFrom;
	///<summary>The material or texture asset we&#39;re dragging to place on an object</summary>
	public UObject PlacingMaterialOrTextureAsset;
}
