#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Singleton wrapper to allow for using the setting structure in SSettingsView</summary>
[CppInclude("MeshApproximationTool/MeshApproximationTool.h")]
public partial class UMeshApproximationSettingsObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public FMeshApproximationSettings Settings;
}
