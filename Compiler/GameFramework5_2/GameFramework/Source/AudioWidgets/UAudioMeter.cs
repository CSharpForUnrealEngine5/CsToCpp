#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An audio meter widget.</summary>
[CppInclude("AudioMeter.h")]
public partial class UAudioMeter : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>FGetMeterChannelInfo</summary>
	public  TArray<FMeterChannelInfo> FGetMeterChannelInfo() { return default; }
	///<summary>The current meter value to display.</summary>
	public TArray<FMeterChannelInfo> MeterChannelInfo;
	///<summary>A bindable delegate to allow logic to drive the value of the meter</summary>
	public FGetMeterChannelInfo MeterChannelInfoDelegate;
	///<summary>The audio meter style</summary>
	public FAudioMeterStyle WidgetStyle;
	///<summary>The slider&#39;s orientation.</summary>
	public EOrientation Orientation;
	///<summary>The color to draw the background.</summary>
	public FLinearColor BackgroundColor;
	///<summary>The color to draw the meter background.</summary>
	public FLinearColor MeterBackgroundColor;
	///<summary>The color to draw the meter value.</summary>
	public FLinearColor MeterValueColor;
	///<summary>The color to draw the meter peak value.</summary>
	public FLinearColor MeterPeakColor;
	///<summary>The color to draw the meter clipping value.</summary>
	public FLinearColor MeterClippingColor;
	///<summary>The color to draw the meter scale hashes.</summary>
	public FLinearColor MeterScaleColor;
	///<summary>The color to draw the meter scale label.</summary>
	public FLinearColor MeterScaleLabelColor;
	///<summary>Gets the current linear value of the meter.</summary>
	public  TArray<FMeterChannelInfo> GetMeterChannelInfo() { return default; }
	///<summary>Sets the current meter values.</summary>
	public  void SetMeterChannelInfo(TArray<FMeterChannelInfo> InMeterChannelInfo) {}
	///<summary>Sets the background color</summary>
	public  void SetBackgroundColor(FLinearColor InValue) {}
	///<summary>Sets the meter background color</summary>
	public  void SetMeterBackgroundColor(FLinearColor InValue) {}
	///<summary>Sets the meter value color</summary>
	public  void SetMeterValueColor(FLinearColor InValue) {}
	///<summary>Sets the meter peak color</summary>
	public  void SetMeterPeakColor(FLinearColor InValue) {}
	///<summary>Sets the meter clipping color</summary>
	public  void SetMeterClippingColor(FLinearColor InValue) {}
	///<summary>Sets the meter scale color</summary>
	public  void SetMeterScaleColor(FLinearColor InValue) {}
	///<summary>Sets the meter scale color</summary>
	public  void SetMeterScaleLabelColor(FLinearColor InValue) {}
}
