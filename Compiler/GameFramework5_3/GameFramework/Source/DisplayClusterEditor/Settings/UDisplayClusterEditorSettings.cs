namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements nDisplay settings</summary>
[CppInclude("Settings/DisplayClusterEditorSettings.h")]
public partial class UDisplayClusterEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>When enabled, replaces the original GameEngine to DisplayClusterGameEngine</summary>
	public bool bEnabled;
	///<summary>When enabled, replaces the original NetDriver to DisplayClusterNetDriver, original NetConnection to DisplayClusterNetDriver</summary>
	public bool bClusterReplicationEnabled;
}
