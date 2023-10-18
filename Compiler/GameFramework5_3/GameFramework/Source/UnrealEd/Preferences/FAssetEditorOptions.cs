namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Options that should be unique per asset editor (like skeletal mesh or anim sequence editors)</summary>
[CppInclude("Preferences/PersonaOptions.h")]
public partial struct FAssetEditorOptions {
	public FName Context;
	public FViewportConfigOptions ViewportConfigs;
}
