#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonInputActionDomain.h")]
///<summary>An ordered array of ActionDomains.</summary>
public partial class UCommonInputActionDomainTable : UDataAsset {
// CommonInputActionDomainTable
	public TArray<UCommonInputActionDomain> ActionDomains;
	public ECommonInputMode InputMode;
	public EMouseCaptureMode MouseCaptureMode;
}
