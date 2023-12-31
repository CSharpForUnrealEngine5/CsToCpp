namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCPropertyDescription {
	public string Name;
	public FText DisplayName;
	public string Description;
	public string Type;
	public FName TypePath;
	public string ContainerType;
	public string KeyType;
	public TMap<FName,string> Metadata;
}
