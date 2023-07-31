#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A function library of utilities for querying information about plugins.</summary>
[CppInclude("PluginBlueprintLibrary.h")]
public partial class UPluginBlueprintLibrary : UBlueprintFunctionLibrary {
	///<summary>Get the list of extra directories that are recursively searched for</summary>
	public static TArray<string> GetAdditionalPluginSearchPaths() { return default; }
	///<summary>Get the list of extra directories added by the project that are</summary>
	public static TArray<string> GetAdditionalProjectPluginSearchPaths() { return default; }
	///<summary>Get the names of all enabled plugins.</summary>
	public static TArray<string> GetEnabledPluginNames() { return default; }
	///<summary>Get the name of the plugin containing an object.</summary>
	public static bool GetPluginNameForObjectPath(FSoftObjectPath ObjectPath,string OutPluginName) { return default; }
	///<summary>Get the filesystem path to a plugin&#39;s descriptor.</summary>
	public static bool GetPluginDescriptorFilePath(string PluginName,string OutFilePath) { return default; }
	///<summary>Get the filesystem path to a plugin&#39;s base directory.</summary>
	public static bool GetPluginBaseDir(string PluginName,string OutBaseDir) { return default; }
	///<summary>Get the filesystem path to a plugin&#39;s content directory.</summary>
	public static bool GetPluginContentDir(string PluginName,string OutContentDir) { return default; }
	///<summary>Get the virtual root path for assets in a plugin.</summary>
	public static bool GetPluginMountedAssetPath(string PluginName,string OutAssetPath) { return default; }
	///<summary>Get the version number of a plugin.</summary>
	public static bool GetPluginVersion(string PluginName,int OutVersion) { return default; }
	///<summary>Get the version name of a plugin.</summary>
	public static bool GetPluginVersionName(string PluginName,string OutVersionName) { return default; }
	///<summary>Get the description of a plugin.</summary>
	public static bool GetPluginDescription(string PluginName,string OutDescription) { return default; }
	///<summary>Get the editor custom virtual path of a plugin.</summary>
	public static bool GetPluginEditorCustomVirtualPath(string PluginName,string OutVirtualPath) { return default; }
	///<summary>Determine whether a plugin is mounted.</summary>
	public static bool IsPluginMounted(string PluginName) { return default; }
}
