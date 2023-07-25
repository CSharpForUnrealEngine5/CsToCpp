#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VREditorPlacement.h")]
///<summary>VR Editor interaction with the 3D world</summary>
public partial class UVREditorPlacement : UObject {
// VREditorPlacement
	public UVREditorMode VRMode;
	public UViewportWorldInteraction ViewportWorldInteraction;
	public UWidgetComponent FloatingUIAssetDraggedFrom;
	public UObject PlacingMaterialOrTextureAsset;
}
