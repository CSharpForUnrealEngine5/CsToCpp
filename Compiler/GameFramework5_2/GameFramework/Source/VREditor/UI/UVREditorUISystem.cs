namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>VR Editor user interface manager</summary>
[CppInclude("UI/VREditorUISystem.h")]
public partial class UVREditorUISystem : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Owning object</summary>
	public UVREditorMode VRMode;
	///<summary>All of the floating UIs.  These may or may not be visible (spawned)</summary>
	public TMap<string,AVREditorFloatingUI> FloatingUIs;
	///<summary>All of the preview window info.</summary>
	public TMap<string,AActor> PreviewWindowInfo;
	///<summary>Our Quick Menu UI</summary>
	public AVREditorFloatingUI InfoDisplayPanel;
	///<summary>The Radial Menu UI</summary>
	public AVREditorRadialFloatingUI QuickRadialMenu;
	///<summary>The current UI that is being dragged</summary>
	public AVREditorDockableWindow DraggingUI;
	///<summary>The color picker dockable window</summary>
	public AVREditorDockableWindow ColorPickerUI;
	///<summary>Interactor that has a laser and is generally interacting with the scene</summary>
	public UVREditorInteractor LaserInteractor;
	///<summary>Interactor that usually accesses UI and other helper functionality</summary>
	public UVREditorInteractor UIInteractor;
	///<summary>All buttons created for the radial and quick menus</summary>
	public TArray<FVRButton> VRButtons;
	///<summary>The add-on that handles radial menu switching</summary>
	public UVRRadialMenuHandler RadialMenuHandler;
}
