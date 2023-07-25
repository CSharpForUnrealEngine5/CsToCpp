#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/EditorProjectSettings.h")]
///<summary>Configure settings for the 2D Level Editor</summary>
public partial class ULevelEditor2DSettings : UDeveloperSettings {
// LevelEditor2DSettings
	public bool bEnable2DWidget;
	public bool bEnableSnapLayers;
	public ELevelEditor2DAxis SnapAxis;
	public TArray<FMode2DLayer> SnapLayers;
}
