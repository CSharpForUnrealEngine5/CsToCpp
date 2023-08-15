namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserConfig.h")]
public partial class UContentBrowserConfig : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>Favorites</summary>
	public TSet<string> Favorites;
	///<summary>Instances</summary>
	public TMap<FName,FContentBrowserInstanceConfig> Instances;
}
