namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>These structures serve both as properties mapping as well as UI generation</summary>
[CppInclude("RemoteControlProtocolBinding.h")]
public partial struct FRemoteControlProtocolEntity {
	public TWeakObjectPtr<URemoteControlPreset> Owner;
	public FGuid PropertyId;
	public TSet<FRemoteControlProtocolMapping> Mappings;
	public ERCMask OverridenMasks;
	public ERCBindingStatus BindingStatus;
}
