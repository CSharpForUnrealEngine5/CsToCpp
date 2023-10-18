namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectLinkExtensionBlueprintLibrary.h")]
public partial class UDirectLinkExtensionBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetAvailableDirectLinkSourcesUri</summary>
	public static TArray<string> GetAvailableDirectLinkSourcesUri() { return default; }
	///<summary>ParseDirectLinkSourceUri</summary>
	public static bool ParseDirectLinkSourceUri(string SourceUriString,string OutComputerName,string OutEndpointName,string OutExecutableName,string OutSourceName) { return default; }
}
