#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PluginBlueprintLibrary.h")]
///<summary>A function library of utilities for querying information about plugins.</summary>
public partial class UPluginBlueprintLibrary : UBlueprintFunctionLibrary {
// PluginBlueprintLibrary
	public static TArray<string> GetAdditionalPluginSearchPaths() { return default; }
	public static TArray<string> GetAdditionalProjectPluginSearchPaths() { return default; }
	public static TArray<string> GetEnabledPluginNames() { return default; }
	public static bool GetPluginNameForObjectPath(FSoftObjectPath ObjectPath,string OutPluginName) { return default; }
	public static bool GetPluginDescriptorFilePath(string PluginName,string OutFilePath) { return default; }
	public static bool GetPluginBaseDir(string PluginName,string OutBaseDir) { return default; }
	public static bool GetPluginContentDir(string PluginName,string OutContentDir) { return default; }
	public static bool GetPluginMountedAssetPath(string PluginName,string OutAssetPath) { return default; }
	public static bool GetPluginVersion(string PluginName,int OutVersion) { return default; }
	public static bool GetPluginVersionName(string PluginName,string OutVersionName) { return default; }
	public static bool GetPluginDescription(string PluginName,string OutDescription) { return default; }
	public static bool GetPluginEditorCustomVirtualPath(string PluginName,string OutVirtualPath) { return default; }
	public static bool IsPluginMounted(string PluginName) { return default; }
}
