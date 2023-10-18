namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Proxy in Details Panel</summary>
[CppInclude("EditMode/ControlRigControlsProxy.h")]
public partial class UControlRigDetailPanelControlProxies : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>AllProxies</summary>
	public TMap<UControlRig,FControlToProxyMap> AllProxies;
	///<summary>proxies themselves contain weakobjectptr to the controlrig</summary>
	public TArray<UControlRigControlsProxy> SelectedProxies;
}
