#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements nDisplay settings</summary>
[CppInclude("Settings/DisplayClusterEditorSettings.h")]
public partial class UDisplayClusterEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>When enabled, replaces the original GameEngine to DisplayClusterGameEngine</summary>
	public bool bEnabled;
}
