namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Singleton wrapper to allow for using the setting structure in SSettingsView</summary>
[CppInclude("MeshMergingTool/MeshMergingTool.h")]
public partial class UMeshMergingSettingsObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public FMeshMergingSettings Settings;
}
