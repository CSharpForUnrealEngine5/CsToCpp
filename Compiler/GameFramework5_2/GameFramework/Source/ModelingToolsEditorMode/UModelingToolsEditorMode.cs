#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelingToolsEditorMode.h")]
public partial class UModelingToolsEditorMode : UBaseLegacyWidgetEdMode {
// ModelingToolsEditorMode
	public bool bEnableVolumeElementSelection;
	public bool bEnableStaticMeshElementSelection;
	public UModelingSceneSnappingManager SceneSnappingManager;
	public UGeometrySelectionManager SelectionManager;
	public UModelingSelectionInteraction SelectionInteraction;
	public TArray<UInteractiveCommand> ModelingModeCommands;
}
