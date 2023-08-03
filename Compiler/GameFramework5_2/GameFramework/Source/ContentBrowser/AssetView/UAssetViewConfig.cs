#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetView/AssetViewConfig.h")]
public partial class UAssetViewConfig : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>Instances</summary>
	public TMap<string,FAssetViewInstanceConfig> Instances;
}
