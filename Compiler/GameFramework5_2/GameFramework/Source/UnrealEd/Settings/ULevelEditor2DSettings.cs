namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configure settings for the 2D Level Editor</summary>
[CppInclude("Settings/EditorProjectSettings.h")]
public partial class ULevelEditor2DSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled, shows the 2D combined translate and rotate tool in the viewport toolbar.</summary>
	public bool bEnable2DWidget;
	///<summary>If enabled, shows the 2D layer snapping controls in the viewport toolbar.</summary>
	public bool bEnableSnapLayers;
	///<summary>Sets the world space axis for 2D snap layers.</summary>
	public ELevelEditor2DAxis SnapAxis;
	///<summary>Snap layers that are displayed in the viewport toolbar.</summary>
	public TArray<FMode2DLayer> SnapLayers;
}
