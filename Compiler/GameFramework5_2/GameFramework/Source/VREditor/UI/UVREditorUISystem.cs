#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/VREditorUISystem.h")]
///<summary>VR Editor user interface manager</summary>
public partial class UVREditorUISystem : UObject {
// VREditorUISystem
	public UVREditorMode VRMode;
	public TMap<string,AVREditorFloatingUI> FloatingUIs;
	public TMap<string,AActor> PreviewWindowInfo;
	public AVREditorFloatingUI InfoDisplayPanel;
	public AVREditorRadialFloatingUI QuickRadialMenu;
	public AVREditorDockableWindow DraggingUI;
	public AVREditorDockableWindow ColorPickerUI;
	public UVREditorInteractor LaserInteractor;
	public UVREditorInteractor UIInteractor;
	public TArray<FVRButton> VRButtons;
	public UVRRadialMenuHandler RadialMenuHandler;
}
