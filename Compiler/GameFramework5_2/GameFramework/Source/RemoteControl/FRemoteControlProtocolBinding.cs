namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct which holds the bound struct and serialized struct archive</summary>
[CppInclude("RemoteControlProtocolBinding.h")]
public partial struct FRemoteControlProtocolBinding {
	public FGuid Id;
	public string ProtocolName;
	public FGuid PropertyId;
	public string MappingPropertyName;
}
