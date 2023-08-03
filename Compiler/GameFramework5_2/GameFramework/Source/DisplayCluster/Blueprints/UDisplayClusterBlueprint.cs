#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/DisplayClusterBlueprint.h")]
public partial class UDisplayClusterBlueprint : UBlueprint {
	public static UClass StaticClass() {return default;}
	///<summary>Whether or not you want to continuously rerun the construction script while dragging a slider</summary>
	public bool bRunConstructionScriptOnInteractiveChange;
	///<summary>Holds the last saved config export. In the AssetRegistry to allow parsing without loading.</summary>
	public string ConfigExport;
	///<summary>ConfigData</summary>
	public UDisplayClusterConfigurationData ConfigData;
	///<summary>AssetVersion</summary>
	public int AssetVersion;
}
