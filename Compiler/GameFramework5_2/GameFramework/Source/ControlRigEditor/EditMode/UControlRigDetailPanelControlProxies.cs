#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditMode/ControlRigControlsProxy.h")]
///<summary>Proxy in Details Panel</summary>
public partial class UControlRigDetailPanelControlProxies : UObject {
// ControlRigDetailPanelControlProxies
	public TMap<UControlRig,FControlToProxyMap> AllProxies;
	public TArray<UControlRigControlsProxy> SelectedProxies;
}
