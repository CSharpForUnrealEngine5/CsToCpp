namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCAssetDescription {
	public FName Name;
	public FName Class;
	public FName Path;
	public TMap<FName,string> Metadata;
}
