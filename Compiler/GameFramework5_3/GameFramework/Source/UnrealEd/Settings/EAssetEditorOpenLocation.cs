namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/EditorStyleSettings.h")]
public enum EAssetEditorOpenLocation {
	Default=0,
	NewWindow=1,
	MainWindow=2,
	ContentBrowser=3,
	LastDockedWindowOrNewWindow=4,
	LastDockedWindowOrMainWindow=5,
	LastDockedWindowOrContentBrowser=6,
}
