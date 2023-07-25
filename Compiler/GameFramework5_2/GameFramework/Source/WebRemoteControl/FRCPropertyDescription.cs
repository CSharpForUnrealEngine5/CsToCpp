#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCPropertyDescription {
// RCPropertyDescription
	public string Name;
	public string DisplayName;
	public string Description;
	public string Type;
	public string TypePath;
	public string ContainerType;
	public string KeyType;
	public TMap<string,string> Metadata;
}
