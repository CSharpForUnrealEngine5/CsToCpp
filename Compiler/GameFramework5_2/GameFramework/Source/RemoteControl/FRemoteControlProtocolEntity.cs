#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlProtocolBinding.h")]
///<summary>These structures serve both as properties mapping as well as UI generation</summary>
public partial struct FRemoteControlProtocolEntity {
// RemoteControlProtocolEntity
	public TWeakObjectPtr<URemoteControlPreset> Owner;
	public FGuid PropertyId;
	public TSet<FRemoteControlProtocolMapping> Mappings;
	public ERCMask OverridenMasks;
	public ERCBindingStatus BindingStatus;
}
