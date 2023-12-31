namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Singleton wrapper to allow for using the setting structure in SSettingsView</summary>
[CppInclude("MeshProxyTool/MeshProxyTool.h")]
public partial class UMeshProxySettingsObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public FMeshProxySettings Settings;
}
