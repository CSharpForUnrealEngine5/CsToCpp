namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonDateTimeTextBlock.h")]
public partial class UCommonDateTimeTextBlock : UCommonTextBlock {
	public static UClass StaticClass() {return default;}
	///<summary>SetDateTimeValue</summary>
	public void SetDateTimeValue(FDateTime InDateTime,bool bShowAsCountdown,float InRefreshDelay/*=1.0f*/) {}
	///<summary>SetTimespanValue</summary>
	public void SetTimespanValue(FTimespan InTimespan) {}
	///<summary>SetCountDownCompletionText</summary>
	public void SetCountDownCompletionText(FText InCompletionText) {}
	///<summary>GetDateTime</summary>
	public FDateTime GetDateTime() { return default; }
}
