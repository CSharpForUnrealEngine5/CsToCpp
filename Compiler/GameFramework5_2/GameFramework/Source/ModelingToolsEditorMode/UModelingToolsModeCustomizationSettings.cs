#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelingToolsEditorModeSettings.h")]
public partial class UModelingToolsModeCustomizationSettings : UDeveloperSettings {
// ModelingToolsModeCustomizationSettings
	public TArray<string> ToolSectionOrder;
	public TArray<string> ToolFavorites;
	public TArray<FModelingModeCustomSectionColor> SectionColors;
	public TArray<FModelingModeCustomToolColor> ToolColors;
	public TArray<FModelingModeAssetCollectionSet> BrushAlphaSets;
	public int LastMeshSelectionDragMode;
	public int LastMeshSelectionElementType;
	public int LastMeshSelectionTopologyMode;
	public bool bLastMeshSelectionVolumeToggle;
	public bool bLastMeshSelectionStaticMeshToggle;
}
