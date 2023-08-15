namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCExposedPropertyDescription {
	public FName DisplayName;
	public string ID;
	public FRCPropertyDescription UnderlyingProperty;
	public TMap<FName,string> Metadata;
	public TArray<FRCObjectDescription> OwnerObjects;
}
