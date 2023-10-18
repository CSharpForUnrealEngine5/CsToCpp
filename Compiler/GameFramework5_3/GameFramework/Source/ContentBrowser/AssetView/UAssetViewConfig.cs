namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetView/AssetViewConfig.h")]
public partial class UAssetViewConfig : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>Instances</summary>
	public TMap<FName,FAssetViewInstanceConfig> Instances;
}
