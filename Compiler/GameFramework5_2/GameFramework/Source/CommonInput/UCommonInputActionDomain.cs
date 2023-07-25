#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonInputActionDomain.h")]
///<summary>Describes an input-event handling domain. It's InnerBehavior determines how events</summary>
public partial class UCommonInputActionDomain : UDataAsset {
// CommonInputActionDomain
	public ECommonInputEventFlowBehavior Behavior;
	public ECommonInputEventFlowBehavior InnerBehavior;
	public bool bUseActionDomainDesiredInputConfig;
	public ECommonInputMode InputMode;
	public EMouseCaptureMode MouseCaptureMode;
}
