#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCExposedPropertyDescription {
// RCExposedPropertyDescription
	public string DisplayName;
	public string ID;
	public FRCPropertyDescription UnderlyingProperty;
	public TMap<string,string> Metadata;
	public TArray<FRCObjectDescription> OwnerObjects;
}
