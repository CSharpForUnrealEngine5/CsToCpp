#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonDateTimeTextBlock.h")]
public partial class UCommonDateTimeTextBlock : UCommonTextBlock {
// CommonDateTimeTextBlock
	public void SetDateTimeValue(FDateTime InDateTime,bool bShowAsCountdown,float InRefreshDelay/*=1.0f*/) {}
	public void SetTimespanValue(FTimespan InTimespan) {}
	public void SetCountDownCompletionText(string InCompletionText) {}
	public FDateTime GetDateTime() { return default; }
}
