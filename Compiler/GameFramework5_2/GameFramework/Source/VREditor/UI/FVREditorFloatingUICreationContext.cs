#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/VREditorFloatingUI.h")]
///<summary>Creation parameters for AVREditorFloatingUI</summary>
public partial struct FVREditorFloatingUICreationContext {
// VREditorFloatingUICreationContext
	public UClass WidgetClass;
	public string PanelID;
	public AActor ParentActor;
	public FTransform PanelSpawnOffset;
	public FVector2D PanelSize;
	public UStaticMesh PanelMesh;
	public float EditorUISize;
	public bool bHideWindowHandles;
	public bool bMaskOutWidgetBackground;
	public bool bNoCloseButton;
}
