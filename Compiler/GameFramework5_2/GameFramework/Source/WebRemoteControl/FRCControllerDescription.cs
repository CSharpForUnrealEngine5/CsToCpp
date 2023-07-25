#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCControllerDescription {
// RCControllerDescription
	public string DisplayName;
	public string ID;
	public string Type;
	public string Path;
	public TMap<string,string> Metadata;
}
