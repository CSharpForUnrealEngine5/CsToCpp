namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Singleton wrapper to allow for using the setting structure in SSettingsView</summary>
[CppInclude("MeshInstancingTool/MeshInstancingTool.h")]
public partial class UMeshInstancingSettingsObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public FMeshInstancingSettings Settings;
}
