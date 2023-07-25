#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserConfig.h")]
public partial class UContentBrowserConfig : UEditorConfigBase {
// ContentBrowserConfig
	public TSet<string> Favorites;
	public TMap<string,FContentBrowserInstanceConfig> Instances;
}
