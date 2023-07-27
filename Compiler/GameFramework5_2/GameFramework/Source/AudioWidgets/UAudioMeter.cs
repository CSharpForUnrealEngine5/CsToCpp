#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioMeter.h")]
///<summary>An audio meter widget.</summary>
public partial class UAudioMeter : UWidget {
// AudioMeter
	public  TArray<FMeterChannelInfo> FGetMeterChannelInfo() { return default; }
	public TArray<FMeterChannelInfo> MeterChannelInfo;
	public FGetMeterChannelInfo MeterChannelInfoDelegate;
	public FAudioMeterStyle WidgetStyle;
	public EOrientation Orientation;
	public FLinearColor BackgroundColor;
	public FLinearColor MeterBackgroundColor;
	public FLinearColor MeterValueColor;
	public FLinearColor MeterPeakColor;
	public FLinearColor MeterClippingColor;
	public FLinearColor MeterScaleColor;
	public FLinearColor MeterScaleLabelColor;
	public  TArray<FMeterChannelInfo> GetMeterChannelInfo() { return default; }
	public  void SetMeterChannelInfo(TArray<FMeterChannelInfo> InMeterChannelInfo) {}
	public  void SetBackgroundColor(FLinearColor InValue) {}
	public  void SetMeterBackgroundColor(FLinearColor InValue) {}
	public  void SetMeterValueColor(FLinearColor InValue) {}
	public  void SetMeterPeakColor(FLinearColor InValue) {}
	public  void SetMeterClippingColor(FLinearColor InValue) {}
	public  void SetMeterScaleColor(FLinearColor InValue) {}
	public  void SetMeterScaleLabelColor(FLinearColor InValue) {}
}
