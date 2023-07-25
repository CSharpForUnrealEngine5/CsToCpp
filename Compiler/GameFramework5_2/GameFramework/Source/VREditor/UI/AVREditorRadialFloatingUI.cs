#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/VREditorRadialFloatingUI.h")]
///<summary>Represents an interactive floating UI panel in the VR Editor</summary>
public partial class AVREditorRadialFloatingUI : AVREditorBaseActor {
// VREditorRadialFloatingUI
	public TArray<UVREditorWidgetComponent> WidgetComponents;
	public UStaticMeshComponent WindowMeshComponent;
	public UStaticMeshComponent ArrowMeshComponent;
	public UVREditorWidgetComponent CentralWidgetComponent;
}
