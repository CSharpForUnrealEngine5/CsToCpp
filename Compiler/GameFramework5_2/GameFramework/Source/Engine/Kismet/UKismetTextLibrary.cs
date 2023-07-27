#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetTextLibrary.h")]
public partial class UKismetTextLibrary : UBlueprintFunctionLibrary {
// KismetTextLibrary
	public static string Conv_VectorToText(FVector InVec) { return default; }
	public static string Conv_Vector2dToText(FVector2D InVec) { return default; }
	public static string Conv_RotatorToText(FRotator InRot) { return default; }
	public static string Conv_TransformToText(FTransform InTrans) { return default; }
	public static string Conv_ObjectToText(UObject InObj) { return default; }
	public static string Conv_ColorToText(FLinearColor InColor) { return default; }
	public static string Conv_TextToString(string InText) { return default; }
	public static string Conv_StringToText(string InString) { return default; }
	public static string Conv_NameToText(string InName) { return default; }
	public static bool TextIsEmpty(string InText) { return default; }
	public static bool TextIsTransient(string InText) { return default; }
	public static bool TextIsCultureInvariant(string InText) { return default; }
	public static string TextToLower(string InText) { return default; }
	public static string TextToUpper(string InText) { return default; }
	public static string TextTrimPreceding(string InText) { return default; }
	public static string TextTrimTrailing(string InText) { return default; }
	public static string TextTrimPrecedingAndTrailing(string InText) { return default; }
	public static string GetEmptyText() { return default; }
	public static bool FindTextInLocalizationTable(string Namespace,string Key,string OutText) { return default; }
	public static bool EqualEqual_TextText(string A,string B) { return default; }
	public static bool EqualEqual_IgnoreCase_TextText(string A,string B) { return default; }
	public static bool NotEqual_TextText(string A,string B) { return default; }
	public static bool NotEqual_IgnoreCase_TextText(string A,string B) { return default; }
	public static string Conv_BoolToText(bool InBool) { return default; }
	public static string Conv_ByteToText(byte Value) { return default; }
	public static string Conv_IntToText(int Value,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/) { return default; }
	public static string Conv_Int64ToText(long Value,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/) { return default; }
	public static string Conv_DoubleToText(double Value,byte RoundingMode,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/,int MinimumFractionalDigits/*=0*/,int MaximumFractionalDigits/*=3*/) { return default; }
	public static string AsCurrencyBase(int BaseValue,string CurrencyCode) { return default; }
	public static string AsCurrency_Integer(int Value,byte RoundingMode,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/,int MinimumFractionalDigits/*=0*/,int MaximumFractionalDigits/*=3*/,string CurrencyCode/*=TEXT("")*/) { return default; }
	public static string AsCurrency_Float(float Value,byte RoundingMode,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/,int MinimumFractionalDigits/*=0*/,int MaximumFractionalDigits/*=3*/,string CurrencyCode/*=TEXT("")*/) { return default; }
	public static string AsPercent_Float(float Value,byte RoundingMode,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/,int MinimumFractionalDigits/*=0*/,int MaximumFractionalDigits/*=3*/) { return default; }
	public static string AsDate_DateTime(FDateTime InDateTime) { return default; }
	public static string AsTimeZoneDate_DateTime(FDateTime InDateTime,string InTimeZone/*=TEXT("")*/) { return default; }
	public static string AsDateTime_DateTime(FDateTime In) { return default; }
	public static string AsTimeZoneDateTime_DateTime(FDateTime InDateTime,string InTimeZone/*=TEXT("")*/) { return default; }
	public static string AsTime_DateTime(FDateTime In) { return default; }
	public static string AsTimeZoneTime_DateTime(FDateTime InDateTime,string InTimeZone/*=TEXT("")*/) { return default; }
	public static string AsTimespan_Timespan(FTimespan InTimespan) { return default; }
	public static string Format(string InPattern,TArray<FFormatArgumentData> InArgs) { return default; }
	public static bool TextIsFromStringTable(string Text) { return default; }
	public static string TextFromStringTable(string TableId,string Key) { return default; }
	public static bool StringTableIdAndKeyFromText(string Text,string OutTableId,string OutKey) { return default; }
	public static void IsPolyglotDataValid(FPolyglotTextData PolyglotData,bool IsValid,string ErrorMessage) {}
	public static string PolyglotDataToText(FPolyglotTextData PolyglotData) { return default; }
}
