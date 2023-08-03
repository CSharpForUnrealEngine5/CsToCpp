#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelingToolsEditorModeSettings.h")]
public partial class UModelingToolsModeCustomizationSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Add the names of Modeling Mode Tool Palette Sections to have them appear at the top of the Tool Palette, in the order listed below.</summary>
	public TArray<string> ToolSectionOrder;
	///<summary>Tool Names listed in the array below will appear in a Favorites section at the top of the Modeling Mode Tool Palette</summary>
	public TArray<string> ToolFavorites;
	///<summary>Custom Section Header Colors for listed Sections in the Modeling Mode Tool Palette</summary>
	public TArray<FModelingModeCustomSectionColor> SectionColors;
	///<summary>Custom Tool Colors for listed Tools in the Modeling Mode Tool Palette.</summary>
	public TArray<FModelingModeCustomToolColor> ToolColors;
	///<summary>A Brush Alpha Set is a named list of Content Browser Collections, which will be shown as a separate tab in</summary>
	public TArray<FModelingModeAssetCollectionSet> BrushAlphaSets;
	///<summary>saved-state for various mode settings that are configured via UI toggles/etc, and not exposed in settings dialog</summary>
	public int LastMeshSelectionDragMode;
	///<summary>saved-state for various mode settings that does not persist between editor runs</summary>
	public int LastMeshSelectionElementType;
	///<summary>LastMeshSelectionTopologyMode</summary>
	public int LastMeshSelectionTopologyMode;
	///<summary>bLastMeshSelectionVolumeToggle</summary>
	public bool bLastMeshSelectionVolumeToggle;
	///<summary>bLastMeshSelectionStaticMeshToggle</summary>
	public bool bLastMeshSelectionStaticMeshToggle;
}
