#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/EditorStyleSettings.h")]
///<summary>Implements the Editor style settings.</summary>
public partial class UEditorStyleSettings : UObject {
// EditorStyleSettings
	public bool bEnableHighDPIAwareness;
	public bool bEnableUserEditorLayoutManagement;
	public EColorVisionDeficiency ColorVisionDeficiencyPreviewType;
	public int ColorVisionDeficiencySeverity;
	public bool bColorVisionDeficiencyCorrection;
	public bool bColorVisionDeficiencyCorrectionPreviewWithDeficiency;
	public FLinearColor SelectionColor;
	public bool bEnableEditorWindowBackgroundColor;
	public FLinearColor EditorWindowBackgroundColor;
	public bool bUseSmallToolBarIcons;
	public bool bUseGrid;
	public FLinearColor RegularColor;
	public FLinearColor RuleColor;
	public FLinearColor CenterColor;
	public uint GridSnapSize;
	public FSlateBrush GraphBackgroundBrush;
	public bool bShowFriendlyNames;
	public bool bShowNativeComponentNames;
	public bool bExpandConfigurationMenus;
	public bool bShowProjectMenus;
	public bool bShowLaunchMenus;
	public bool bShowAllAdvancedDetails;
	public bool bShowHiddenPropertiesWhilePlaying;
	public EAssetEditorOpenLocation AssetEditorOpenLocation;
	public bool bEnableColorizedEditorTabs;
	public FGuid CurrentAppliedTheme;
}
