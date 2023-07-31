#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the Widget Blueprint Designer.</summary>
[CppInclude("Settings/WidgetDesignerSettings.h")]
public partial class UWidgetDesignerSettings : UDeveloperSettings {
	///<summary>If enabled, actor positions will snap to the grid.</summary>
	public bool GridSnapEnabled;
	///<summary>GridSnapSize</summary>
	public int GridSnapSize;
	///<summary>bLockToPanelOnDragByDefault</summary>
	public bool bLockToPanelOnDragByDefault;
	///<summary>The default preview resolution in the designer.</summary>
	public FUintVector2 DefaultPreviewResolution;
	///<summary>Should the designer show outlines by default?</summary>
	public bool bShowOutlines;
	///<summary>Should the designer run the design event?  Disable this if you&#39;re seeing crashes in the designer,</summary>
	public bool bExecutePreConstructEvent;
	///<summary>Should the designer respect locked widgets?  If true, the designer by default</summary>
	public bool bRespectLocks;
	///<summary>Setting to automatically create compile tab based on compile results</summary>
	public EDisplayOnCompile CreateOnCompile;
	///<summary>Setting to automatically dismiss compile tab based on compile results</summary>
	public EDisplayOnCompile DismissOnCompile;
	///<summary>List of Favorites widgets used to populate the Favorites Palette</summary>
	public UWidgetPaletteFavorites Favorites;
}
