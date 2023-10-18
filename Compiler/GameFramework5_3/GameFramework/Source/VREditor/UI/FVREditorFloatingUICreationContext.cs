namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Creation parameters for AVREditorFloatingUI</summary>
[CppInclude("UI/VREditorFloatingUI.h")]
public partial struct FVREditorFloatingUICreationContext {
	public UClass WidgetClass;
	public FName PanelID;
	public AActor ParentActor;
	public FTransform PanelSpawnOffset;
	public FVector2D PanelSize;
	public UStaticMesh PanelMesh;
	public float EditorUISize;
	public bool bHideWindowHandles;
	public bool bMaskOutWidgetBackground;
	public bool bNoCloseButton;
}
