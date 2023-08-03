#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The original format of the DisplayCluster config data UAsset, used only for importing 4.26 assets.</summary>
[CppInclude("DisplayClusterConfiguratorVersionUtils.h")]
public partial class UDisplayClusterConfiguratorEditorData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>nDisplayConfig</summary>
	public UDisplayClusterConfigurationData nDisplayConfig;
	///<summary>PathToConfig</summary>
	public string PathToConfig;
	///<summary>True if the original asset is imported but could not be deleted.</summary>
	public bool bConvertedToBlueprint;
}
