#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCAssetDescription {
// RCAssetDescription
	public string Name;
	public string Class;
	public string Path;
	public TMap<string,string> Metadata;
}
