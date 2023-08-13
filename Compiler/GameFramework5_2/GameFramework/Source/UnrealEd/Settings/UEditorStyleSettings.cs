namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Editor style settings.</summary>
[CppInclude("Settings/EditorStyleSettings.h")]
public partial class UEditorStyleSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Enables high dpi support in the editor which will adjust the scale of elements in the UI to account for high DPI monitors</summary>
	public bool bEnableHighDPIAwareness;
	///<summary>Whether to enable the Editor UI Layout configuration tools for the user.</summary>
	public bool bEnableUserEditorLayoutManagement;
	///<summary>Applies a color vision deficiency filter to the entire editor</summary>
	public EColorVisionDeficiency ColorVisionDeficiencyPreviewType;
	///<summary>ColorVisionDeficiencySeverity</summary>
	public int ColorVisionDeficiencySeverity;
	///<summary>Shifts the color spectrum to the visible range based on the current ColorVisionDeficiencyPreviewType</summary>
	public bool bColorVisionDeficiencyCorrection;
	///<summary>If you&#39;re correcting the color deficiency, you can use this to visualize what the correction looks like with the deficiency.</summary>
	public bool bColorVisionDeficiencyCorrectionPreviewWithDeficiency;
	///<summary>The color used to represent selection</summary>
	public FLinearColor SelectionColor;
	///<summary>bEnableEditorWindowBackgroundColor</summary>
	public bool bEnableEditorWindowBackgroundColor;
	///<summary>The color used to tint the editor window backgrounds</summary>
	public FLinearColor EditorWindowBackgroundColor;
	///<summary>Whether to use small toolbar icons without labels or not.</summary>
	public bool bUseSmallToolBarIcons;
	///<summary>If true the material editor and blueprint editor will show a grid on it&#39;s background.</summary>
	public bool bUseGrid;
	///<summary>The color used to represent regular grid lines</summary>
	public FLinearColor RegularColor;
	///<summary>The color used to represent ruler lines in the grid</summary>
	public FLinearColor RuleColor;
	///<summary>The color used to represent the center lines in the grid</summary>
	public FLinearColor CenterColor;
	///<summary>The custom grid snap size to use</summary>
	public uint GridSnapSize;
	///<summary>Optional brush used for graph backgrounds</summary>
	public FSlateBrush GraphBackgroundBrush;
	///<summary>When enabled, the C++ names for properties and functions will be displayed in a format that is easier to read</summary>
	public bool bShowFriendlyNames;
	///<summary>When enabled, the underlying Names for Components inherited from C++ will be shown alongside their UProperty Variable name</summary>
	public bool bShowNativeComponentNames;
	///<summary>When enabled, the Editor Preferences and Project Settings menu items in the main menu will be expanded with sub-menus for each settings section.</summary>
	public bool bExpandConfigurationMenus;
	///<summary>When enabled, the project subsection of the File menu will be shown.</summary>
	public bool bShowProjectMenus;
	///<summary>When enabled, the Launch menu items will be shown.</summary>
	public bool bShowLaunchMenus;
	///<summary>When enabled, the Advanced Details will always auto expand.</summary>
	public bool bShowAllAdvancedDetails;
	///<summary>When Playing or Simulating, shows all properties (even non-visible and non-editable properties), if the object belongs to a simulating world.  This is useful for debugging.</summary>
	public bool bShowHiddenPropertiesWhilePlaying;
	///<summary>New asset editor tabs will open at the specified location.</summary>
	public EAssetEditorOpenLocation AssetEditorOpenLocation;
	///<summary>Should editor tabs be colorized according to the asset type</summary>
	public bool bEnableColorizedEditorTabs;
	///<summary>CurrentAppliedTheme</summary>
	public FGuid CurrentAppliedTheme;
}
