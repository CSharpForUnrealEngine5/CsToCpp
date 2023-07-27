#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/WidgetDesignerSettings.h")]
///<summary>Implements the settings for the Widget Blueprint Designer.</summary>
public partial class UWidgetDesignerSettings : UDeveloperSettings {
// WidgetDesignerSettings
	public bool GridSnapEnabled;
	public int GridSnapSize;
	public bool bLockToPanelOnDragByDefault;
	public FUintVector2 DefaultPreviewResolution;
	public bool bShowOutlines;
	public bool bExecutePreConstructEvent;
	public bool bRespectLocks;
	public EDisplayOnCompile CreateOnCompile;
	public EDisplayOnCompile DismissOnCompile;
	public UWidgetPaletteFavorites Favorites;
}
