#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetTextLibrary.h")]
public partial class UKismetTextLibrary : UBlueprintFunctionLibrary {
// KismetTextLibrary
	public string Conv_VectorToText(FVector InVec) { return default; }
	public string Conv_Vector2dToText(FVector2D InVec) { return default; }
	public string Conv_RotatorToText(FRotator InRot) { return default; }
	public string Conv_TransformToText(FTransform InTrans) { return default; }
	public string Conv_ObjectToText(UObject InObj) { return default; }
	public string Conv_ColorToText(FLinearColor InColor) { return default; }
	public string Conv_TextToString(string InText) { return default; }
	public string Conv_StringToText(string InString) { return default; }
	public string Conv_NameToText(string InName) { return default; }
	public bool TextIsEmpty(string InText) { return default; }
	public bool TextIsTransient(string InText) { return default; }
	public bool TextIsCultureInvariant(string InText) { return default; }
	public string TextToLower(string InText) { return default; }
	public string TextToUpper(string InText) { return default; }
	public string TextTrimPreceding(string InText) { return default; }
	public string TextTrimTrailing(string InText) { return default; }
	public string TextTrimPrecedingAndTrailing(string InText) { return default; }
	public string GetEmptyText() { return default; }
	public bool FindTextInLocalizationTable(string Namespace,string Key,string OutText) { return default; }
	public bool EqualEqual_TextText(string A,string B) { return default; }
	public bool EqualEqual_IgnoreCase_TextText(string A,string B) { return default; }
	public bool NotEqual_TextText(string A,string B) { return default; }
	public bool NotEqual_IgnoreCase_TextText(string A,string B) { return default; }
	public string Conv_BoolToText(bool InBool) { return default; }
	public string Conv_ByteToText(byte Value) { return default; }
	public string Conv_IntToText(int Value,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/) { return default; }
	public string Conv_Int64ToText(long Value,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/) { return default; }
	public string Conv_DoubleToText(double Value,byte RoundingMode,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/,int MinimumFractionalDigits/*=0*/,int MaximumFractionalDigits/*=3*/) { return default; }
	public string AsCurrencyBase(int BaseValue,string CurrencyCode) { return default; }
	public string AsCurrency_Integer(int Value,byte RoundingMode,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/,int MinimumFractionalDigits/*=0*/,int MaximumFractionalDigits/*=3*/,string CurrencyCode/*=TEXT("")*/) { return default; }
	public string AsCurrency_Float(float Value,byte RoundingMode,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/,int MinimumFractionalDigits/*=0*/,int MaximumFractionalDigits/*=3*/,string CurrencyCode/*=TEXT("")*/) { return default; }
	public string AsPercent_Float(float Value,byte RoundingMode,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/,int MinimumFractionalDigits/*=0*/,int MaximumFractionalDigits/*=3*/) { return default; }
	public string AsDate_DateTime(FDateTime InDateTime) { return default; }
	public string AsTimeZoneDate_DateTime(FDateTime InDateTime,string InTimeZone/*=TEXT("")*/) { return default; }
	public string AsDateTime_DateTime(FDateTime In) { return default; }
	public string AsTimeZoneDateTime_DateTime(FDateTime InDateTime,string InTimeZone/*=TEXT("")*/) { return default; }
	public string AsTime_DateTime(FDateTime In) { return default; }
	public string AsTimeZoneTime_DateTime(FDateTime InDateTime,string InTimeZone/*=TEXT("")*/) { return default; }
	public string AsTimespan_Timespan(FTimespan InTimespan) { return default; }
	public string Format(string InPattern,TArray<FFormatArgumentData> InArgs) { return default; }
	public bool TextIsFromStringTable(string Text) { return default; }
	public string TextFromStringTable(string TableId,string Key) { return default; }
	public bool StringTableIdAndKeyFromText(string Text,string OutTableId,string OutKey) { return default; }
	public void IsPolyglotDataValid(FPolyglotTextData PolyglotData,bool IsValid,string ErrorMessage) {}
	public string PolyglotDataToText(FPolyglotTextData PolyglotData) { return default; }
}
