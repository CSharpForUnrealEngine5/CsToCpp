#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/VREditorFloatingUI.h")]
///<summary>Represents an interactive floating UI panel in the VR Editor</summary>
public partial class AVREditorFloatingUI : AVREditorBaseActor {
// VREditorFloatingUI
	public FVREditorFloatingUICreationContext CreationContext;
	public UUserWidget UserWidget;
	public UVREditorWidgetComponent WidgetComponent;
	public UStaticMeshComponent WindowMeshComponent;
	public UClass UserWidgetClass;
}
