#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveCodingSettings.h")]
public partial class ULiveCodingSettings : UObject {
// LiveCodingSettings
	public bool bEnabled;
	public ELiveCodingStartupMode Startup;
	public bool bEnableReinstancing;
	public bool bAutomaticallyCompileNewClasses;
	public bool bPreloadEngineModules;
	public bool bPreloadEnginePluginModules;
	public bool bPreloadProjectModules;
	public bool bPreloadProjectPluginModules;
	public TArray<string> PreloadNamedModules;
}
