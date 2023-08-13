namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveCodingSettings.h")]
public partial class ULiveCodingSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>bEnabled</summary>
	public bool bEnabled;
	///<summary>Startup</summary>
	public ELiveCodingStartupMode Startup;
	///<summary>bEnableReinstancing</summary>
	public bool bEnableReinstancing;
	///<summary>bAutomaticallyCompileNewClasses</summary>
	public bool bAutomaticallyCompileNewClasses;
	///<summary>bPreloadEngineModules</summary>
	public bool bPreloadEngineModules;
	///<summary>bPreloadEnginePluginModules</summary>
	public bool bPreloadEnginePluginModules;
	///<summary>bPreloadProjectModules</summary>
	public bool bPreloadProjectModules;
	///<summary>bPreloadProjectPluginModules</summary>
	public bool bPreloadProjectPluginModules;
	///<summary>PreloadNamedModules</summary>
	public TArray<string> PreloadNamedModules;
}
