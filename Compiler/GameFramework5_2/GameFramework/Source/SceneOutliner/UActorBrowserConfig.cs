#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorBrowsingModeSettings.h")]
public partial class UActorBrowserConfig : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>ActorBrowsers</summary>
	public TMap<string,FActorBrowsingModeConfig> ActorBrowsers;
}
