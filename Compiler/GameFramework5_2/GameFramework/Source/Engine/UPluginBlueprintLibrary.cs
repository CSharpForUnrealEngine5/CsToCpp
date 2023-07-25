#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PluginBlueprintLibrary.h")]
///<summary>A function library of utilities for querying information about plugins.</summary>
public partial class UPluginBlueprintLibrary : UBlueprintFunctionLibrary {
// PluginBlueprintLibrary
	public TArray<string> GetAdditionalPluginSearchPaths() { return default; }
	public TArray<string> GetAdditionalProjectPluginSearchPaths() { return default; }
	public TArray<string> GetEnabledPluginNames() { return default; }
	public bool GetPluginNameForObjectPath(FSoftObjectPath ObjectPath,string OutPluginName) { return default; }
	public bool GetPluginDescriptorFilePath(string PluginName,string OutFilePath) { return default; }
	public bool GetPluginBaseDir(string PluginName,string OutBaseDir) { return default; }
	public bool GetPluginContentDir(string PluginName,string OutContentDir) { return default; }
	public bool GetPluginMountedAssetPath(string PluginName,string OutAssetPath) { return default; }
	public bool GetPluginVersion(string PluginName,int OutVersion) { return default; }
	public bool GetPluginVersionName(string PluginName,string OutVersionName) { return default; }
	public bool GetPluginDescription(string PluginName,string OutDescription) { return default; }
	public bool GetPluginEditorCustomVirtualPath(string PluginName,string OutVirtualPath) { return default; }
	public bool IsPluginMounted(string PluginName) { return default; }
}
