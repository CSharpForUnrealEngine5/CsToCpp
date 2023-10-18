namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An ordered array of ActionDomains.</summary>
[CppInclude("CommonInputActionDomain.h")]
public partial class UCommonInputActionDomainTable : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Domains will receive events in ascending index order</summary>
	public TArray<UCommonInputActionDomain> ActionDomains;
	///<summary>InputMode</summary>
	public ECommonInputMode InputMode;
	///<summary>MouseCaptureMode</summary>
	public EMouseCaptureMode MouseCaptureMode;
}
