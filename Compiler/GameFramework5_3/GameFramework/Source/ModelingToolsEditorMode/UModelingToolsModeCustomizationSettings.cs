namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelingToolsEditorModeSettings.h")]
public partial class UModelingToolsModeCustomizationSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Toggle between the Legacy Modeling Mode Palette and the new UI (requires exiting and re-entering the Mode)</summary>
	public bool bUseLegacyModelingPalette;
	///<summary>Add the names of Modeling Mode Tool Palette Sections to have them appear at the top of the Tool Palette, in the order listed below.</summary>
	public TArray<string> ToolSectionOrder;
	///<summary>Custom Section Header Colors for listed Sections in the Modeling Mode Tool Palette</summary>
	public TArray<FModelingModeCustomSectionColor> SectionColors;
	///<summary>Custom Tool Colors for listed Tools in the Modeling Mode Tool Palette.</summary>
	public TArray<FModelingModeCustomToolColor> ToolColors;
	///<summary>A Brush Alpha Set is a named list of Content Browser Collections, which will be shown as a separate tab in</summary>
	public TArray<FModelingModeAssetCollectionSet> BrushAlphaSets;
	///<summary>If true, the category labels will be shown on the toolbar buttons, else they will be hidden</summary>
	public bool bShowCategoryButtonLabels;
	///<summary>If true, Tool buttons will always be shown when in a Tool. By default they will be hidden.</summary>
	public bool bAlwaysShowToolButtons;
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
