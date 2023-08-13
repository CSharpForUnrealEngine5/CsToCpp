namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorBrowsingModeSettings.h")]
public partial class UActorBrowserConfig : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>ActorBrowsers</summary>
	public TMap<string,FActorBrowsingModeConfig> ActorBrowsers;
}
