#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelingToolsEditorMode.h")]
public partial class UModelingToolsEditorMode : UBaseLegacyWidgetEdMode {
	public static UClass StaticClass() {return default;}
	///<summary>bEnableVolumeElementSelection</summary>
	public bool bEnableVolumeElementSelection;
	///<summary>bEnableStaticMeshElementSelection</summary>
	public bool bEnableStaticMeshElementSelection;
	///<summary>SceneSnappingManager</summary>
	public UModelingSceneSnappingManager SceneSnappingManager;
	///<summary>SelectionManager</summary>
	public UGeometrySelectionManager SelectionManager;
	///<summary>SelectionInteraction</summary>
	public UModelingSelectionInteraction SelectionInteraction;
	///<summary>UInteractiveCommand support. Currently implemented by creating instances of</summary>
	public TArray<UInteractiveCommand> ModelingModeCommands;
}
