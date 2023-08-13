namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes an input-event handling domain. It&#39;s InnerBehavior determines how events</summary>
[CppInclude("CommonInputActionDomain.h")]
public partial class UCommonInputActionDomain : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Behavior of an input event between Action Domains, i.e., how an event flows into the next Action Domain</summary>
	public ECommonInputEventFlowBehavior Behavior;
	///<summary>Behavior of an input event within an Action Domain, i.e., how an event flows to a lower ZOrder active widget</summary>
	public ECommonInputEventFlowBehavior InnerBehavior;
	///<summary>bUseActionDomainDesiredInputConfig</summary>
	public bool bUseActionDomainDesiredInputConfig;
	///<summary>InputMode</summary>
	public ECommonInputMode InputMode;
	///<summary>MouseCaptureMode</summary>
	public EMouseCaptureMode MouseCaptureMode;
}
