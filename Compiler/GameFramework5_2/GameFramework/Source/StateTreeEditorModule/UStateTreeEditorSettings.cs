#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeEditorSettings.h")]
public partial class UStateTreeEditorSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Determines when to save StateTrees post-compile</summary>
	public EStateTreeSaveOnCompile SaveOnCompile;
}
