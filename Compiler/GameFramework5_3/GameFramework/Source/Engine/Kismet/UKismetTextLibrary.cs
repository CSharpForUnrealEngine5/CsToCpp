namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetTextLibrary.h")]
public partial class UKismetTextLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Converts a vector value to localized formatted text, in the form &#39;X= Y= Z=&#39;</summary>
	public static FText Conv_VectorToText(FVector InVec) { return default; }
	///<summary>Converts a vector2d value to localized formatted text, in the form &#39;X= Y=&#39;</summary>
	public static FText Conv_Vector2dToText(FVector2D InVec) { return default; }
	///<summary>Converts a rotator value to localized formatted text, in the form &#39;P= Y= R=&#39;</summary>
	public static FText Conv_RotatorToText(FRotator InRot) { return default; }
	///<summary>Converts a transform value to localized formatted text, in the form &#39;Translation: X= Y= Z= Rotation: P= Y= R= Scale: X= Y= Z=&#39;</summary>
	public static FText Conv_TransformToText(FTransform InTrans) { return default; }
	///<summary>Converts a UObject value to culture invariant text by calling the object&#39;s GetName method</summary>
	public static FText Conv_ObjectToText(UObject InObj) { return default; }
	///<summary>Converts a linear color value to localized formatted text, in the form &#39;(R=,G=,B=,A=)&#39;</summary>
	public static FText Conv_ColorToText(FLinearColor InColor) { return default; }
	///<summary>Converts localizable text to the string</summary>
	public static string Conv_TextToString(FText InText) { return default; }
	///<summary>Converts string to culture invariant text. Use Format or Make Literal Text to create localizable text</summary>
	public static FText Conv_StringToText(string InString) { return default; }
	///<summary>Converts Name to culture invariant text</summary>
	public static FText Conv_NameToText(FName InName) { return default; }
	///<summary>Returns true if text is empty.</summary>
	public static bool TextIsEmpty(FText InText) { return default; }
	///<summary>Returns true if text is transient.</summary>
	public static bool TextIsTransient(FText InText) { return default; }
	///<summary>Returns true if text is culture invariant.</summary>
	public static bool TextIsCultureInvariant(FText InText) { return default; }
	///<summary>Transforms the text to lowercase in a culture correct way.</summary>
	public static FText TextToLower(FText InText) { return default; }
	///<summary>Transforms the text to uppercase in a culture correct way.</summary>
	public static FText TextToUpper(FText InText) { return default; }
	///<summary>Removes whitespace characters from the front of the text.</summary>
	public static FText TextTrimPreceding(FText InText) { return default; }
	///<summary>Removes trailing whitespace characters.</summary>
	public static FText TextTrimTrailing(FText InText) { return default; }
	///<summary>Removes whitespace characters from the front and end of the text.</summary>
	public static FText TextTrimPrecedingAndTrailing(FText InText) { return default; }
	///<summary>Returns an empty piece of text.</summary>
	public static FText GetEmptyText() { return default; }
	///<summary>Attempts to find existing Text using the representation found in the loc tables for the specified namespace and key.</summary>
	public static bool FindTextInLocalizationTable(string Namespace,string Key,FText OutText,string SourceString/*=TEXT("")*/) { return default; }
	///<summary>Returns true if A and B are linguistically equal (A == B).</summary>
	public static bool EqualEqual_TextText(FText A,FText B) { return default; }
	///<summary>Returns true if A and B are linguistically equal (A == B), ignoring case.</summary>
	public static bool EqualEqual_IgnoreCase_TextText(FText A,FText B) { return default; }
	///<summary>Returns true if A and B are linguistically not equal (A != B).</summary>
	public static bool NotEqual_TextText(FText A,FText B) { return default; }
	///<summary>Returns true if A and B are linguistically not equal (A != B), ignoring case.</summary>
	public static bool NotEqual_IgnoreCase_TextText(FText A,FText B) { return default; }
	///<summary>Converts a boolean value to formatted text, either &#39;true&#39; or &#39;false&#39;</summary>
	public static FText Conv_BoolToText(bool InBool) { return default; }
	///<summary>Converts a byte value to formatted text</summary>
	public static FText Conv_ByteToText(byte Value) { return default; }
	///<summary>Converts a passed in integer to text based on formatting options</summary>
	public static FText Conv_IntToText(int Value,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/) { return default; }
	///<summary>Converts a passed in integer to text based on formatting options</summary>
	public static FText Conv_Int64ToText(long Value,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/) { return default; }
	///<summary>Converts a passed in double to text based on formatting options</summary>
	public static FText Conv_DoubleToText(double Value,ERoundingMode RoundingMode,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/,int MinimumFractionalDigits/*=0*/,int MaximumFractionalDigits/*=3*/) { return default; }
	///<summary>Generate an FText that represents the passed number as currency in the current culture.</summary>
	public static FText AsCurrencyBase(int BaseValue,string CurrencyCode) { return default; }
	///<summary>Converts a passed in integer to a text formatted as a currency</summary>
	public static FText AsCurrency_Integer(int Value,ERoundingMode RoundingMode,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/,int MinimumFractionalDigits/*=0*/,int MaximumFractionalDigits/*=3*/,string CurrencyCode/*=TEXT("")*/) { return default; }
	///<summary>Converts a passed in float to a text formatted as a currency</summary>
	public static FText AsCurrency_Float(float Value,ERoundingMode RoundingMode,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/,int MinimumFractionalDigits/*=0*/,int MaximumFractionalDigits/*=3*/,string CurrencyCode/*=TEXT("")*/) { return default; }
	///<summary>Converts a passed in float to a text, formatted as a percent</summary>
	public static FText AsPercent_Float(float Value,ERoundingMode RoundingMode,bool bAlwaysSign/*=false*/,bool bUseGrouping/*=true*/,int MinimumIntegralDigits/*=1*/,int MaximumIntegralDigits/*=324*/,int MinimumFractionalDigits/*=0*/,int MaximumFractionalDigits/*=3*/) { return default; }
	///<summary>Converts a passed in date &amp; time to a text, formatted as a date using an invariant timezone. This will use the given date &amp; time as-is, so it&#39;s assumed to already be in the correct timezone.</summary>
	public static FText AsDate_DateTime(FDateTime InDateTime) { return default; }
	///<summary>Converts a passed in date &amp; time to a text, formatted as a date using the given timezone (default is the local timezone). This will convert the given date &amp; time from UTC to the given timezone (taking into account DST).</summary>
	public static FText AsTimeZoneDate_DateTime(FDateTime InDateTime,string InTimeZone/*=TEXT("")*/) { return default; }
	///<summary>Converts a passed in date &amp; time to a text, formatted as a date &amp; time using an invariant timezone. This will use the given date &amp; time as-is, so it&#39;s assumed to already be in the correct timezone.</summary>
	public static FText AsDateTime_DateTime(FDateTime In) { return default; }
	///<summary>Converts a passed in date &amp; time to a text, formatted as a date &amp; time using the given timezone (default is the local timezone). This will convert the given date &amp; time from UTC to the given timezone (taking into account DST).</summary>
	public static FText AsTimeZoneDateTime_DateTime(FDateTime InDateTime,string InTimeZone/*=TEXT("")*/) { return default; }
	///<summary>Converts a passed in date &amp; time to a text, formatted as a time using an invariant timezone. This will use the given date &amp; time as-is, so it&#39;s assumed to already be in the correct timezone.</summary>
	public static FText AsTime_DateTime(FDateTime In) { return default; }
	///<summary>Converts a passed in date &amp; time to a text, formatted as a time using the given timezone (default is the local timezone). This will convert the given date &amp; time from UTC to the given timezone (taking into account DST).</summary>
	public static FText AsTimeZoneTime_DateTime(FDateTime InDateTime,string InTimeZone/*=TEXT("")*/) { return default; }
	///<summary>Converts a passed in time span to a text, formatted as a time span</summary>
	public static FText AsTimespan_Timespan(FTimespan InTimespan) { return default; }
	///<summary>Used for formatting text using the FText::Format function and utilized by the UK2Node_FormatText</summary>
	public static FText Format(FText InPattern,TArray<FFormatArgumentData> InArgs) { return default; }
	///<summary>Returns true if the given text is referencing a string table.</summary>
	public static bool TextIsFromStringTable(FText Text) { return default; }
	///<summary>Attempts to create a text instance from a string table ID and key.</summary>
	public static FText TextFromStringTable(FName TableId,string Key) { return default; }
	///<summary>Attempts to find the String Table ID and key used by the given text.</summary>
	public static bool StringTableIdAndKeyFromText(FText Text,FName OutTableId,string OutKey) { return default; }
	///<summary>Check whether the given polyglot data is valid.</summary>
	public static void IsPolyglotDataValid(FPolyglotTextData PolyglotData,bool IsValid,FText ErrorMessage) {}
	///<summary>Get the text instance created from this polyglot data.</summary>
	public static FText PolyglotDataToText(FPolyglotTextData PolyglotData) { return default; }
}
