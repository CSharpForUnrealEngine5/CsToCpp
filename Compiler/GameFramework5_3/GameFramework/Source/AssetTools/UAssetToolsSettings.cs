namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetToolsSettings.h")]
public partial class UAssetToolsSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>List of rules to use when advanced copying assets</summary>
	public TArray<FAdvancedCopyMap> AdvancedCopyCustomizations;
}
