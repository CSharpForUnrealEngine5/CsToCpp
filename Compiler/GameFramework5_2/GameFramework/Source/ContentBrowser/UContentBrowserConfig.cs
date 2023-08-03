#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserConfig.h")]
public partial class UContentBrowserConfig : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>Favorites</summary>
	public TSet<string> Favorites;
	///<summary>Instances</summary>
	public TMap<string,FContentBrowserInstanceConfig> Instances;
}
