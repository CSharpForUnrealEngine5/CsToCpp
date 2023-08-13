namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCExposedPropertyDescription {
	public string DisplayName;
	public string ID;
	public FRCPropertyDescription UnderlyingProperty;
	public TMap<string,string> Metadata;
	public TArray<FRCObjectDescription> OwnerObjects;
}
