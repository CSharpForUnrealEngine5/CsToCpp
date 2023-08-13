namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCAssetDescription {
	public string Name;
	public string Class;
	public string Path;
	public TMap<string,string> Metadata;
}
