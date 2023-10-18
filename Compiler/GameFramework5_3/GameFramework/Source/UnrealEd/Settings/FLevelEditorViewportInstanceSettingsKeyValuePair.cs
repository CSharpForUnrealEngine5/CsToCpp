namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a key -&gt; value pair for the per-instance view port settings</summary>
[CppInclude("Settings/LevelEditorViewportSettings.h")]
public partial struct FLevelEditorViewportInstanceSettingsKeyValuePair {
	public string ConfigName;
	public FLevelEditorViewportInstanceSettings ConfigSettings;
}
