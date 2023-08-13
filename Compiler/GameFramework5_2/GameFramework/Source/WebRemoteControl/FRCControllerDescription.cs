namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCControllerDescription {
	public string DisplayName;
	public string ID;
	public string Type;
	public string Path;
	public TMap<string,string> Metadata;
}
