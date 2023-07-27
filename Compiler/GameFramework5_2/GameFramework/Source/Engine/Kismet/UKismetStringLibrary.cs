#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetStringLibrary.h")]
public partial class UKismetStringLibrary : UBlueprintFunctionLibrary {
// KismetStringLibrary
	public static string Conv_DoubleToString(double InDouble) { return default; }
	public static string Conv_IntToString(int InInt) { return default; }
	public static string Conv_Int64ToString(long InInt) { return default; }
	public static string Conv_ByteToString(byte InByte) { return default; }
	public static string Conv_BoolToString(bool InBool) { return default; }
	public static string Conv_VectorToString(FVector InVec) { return default; }
	public static string Conv_Vector3fToString(FVector3f InVec) { return default; }
	public static string Conv_IntVectorToString(FIntVector InIntVec) { return default; }
	public static string Conv_IntPointToString(FIntPoint InIntPoint) { return default; }
	public static string Conv_Vector2dToString(FVector2D InVec) { return default; }
	public static string Conv_RotatorToString(FRotator InRot) { return default; }
	public static string Conv_TransformToString(FTransform InTrans) { return default; }
	public static string Conv_ObjectToString(UObject InObj) { return default; }
	public static string Conv_InputDeviceIdToString(FInputDeviceId InDeviceId) { return default; }
	public static string Conv_PlatformUserIdToString(FPlatformUserId InPlatformUserId) { return default; }
	public static string Conv_ColorToString(FLinearColor InColor) { return default; }
	public static string Conv_NameToString(string InName) { return default; }
	public static string Conv_MatrixToString(FMatrix InMatrix) { return default; }
	public static string Conv_StringToName(string InString) { return default; }
	public static int Conv_StringToInt(string InString) { return default; }
	public static long Conv_StringToInt64(string InString) { return default; }
	public static double Conv_StringToDouble(string InString) { return default; }
	public static void Conv_StringToVector(string InString,FVector OutConvertedVector,bool OutIsValid) {}
	public static void Conv_StringToVector3f(string InString,FVector3f OutConvertedVector,bool OutIsValid) {}
	public static void Conv_StringToVector2D(string InString,FVector2D OutConvertedVector2D,bool OutIsValid) {}
	public static void Conv_StringToRotator(string InString,FRotator OutConvertedRotator,bool OutIsValid) {}
	public static void Conv_StringToColor(string InString,FLinearColor OutConvertedColor,bool OutIsValid) {}
	public static string BuildString_Double(string AppendTo,string Prefix,double InDouble,string Suffix) { return default; }
	public static string BuildString_Int(string AppendTo,string Prefix,int InInt,string Suffix) { return default; }
	public static string BuildString_Bool(string AppendTo,string Prefix,bool InBool,string Suffix) { return default; }
	public static string BuildString_Vector(string AppendTo,string Prefix,FVector InVector,string Suffix) { return default; }
	public static string BuildString_IntVector(string AppendTo,string Prefix,FIntVector InIntVector,string Suffix) { return default; }
	public static string BuildString_Vector2d(string AppendTo,string Prefix,FVector2D InVector2d,string Suffix) { return default; }
	public static string BuildString_Rotator(string AppendTo,string Prefix,FRotator InRot,string Suffix) { return default; }
	public static string BuildString_Object(string AppendTo,string Prefix,UObject InObj,string Suffix) { return default; }
	public static string BuildString_Color(string AppendTo,string Prefix,FLinearColor InColor,string Suffix) { return default; }
	public static string BuildString_Name(string AppendTo,string Prefix,string InName,string Suffix) { return default; }
	public static string Concat_StrStr(string A,string B) { return default; }
	public static bool EqualEqual_StrStr(string A,string B) { return default; }
	public static bool EqualEqual_StriStri(string A,string B) { return default; }
	public static bool NotEqual_StrStr(string A,string B) { return default; }
	public static bool NotEqual_StriStri(string A,string B) { return default; }
	public static int Len(string S) { return default; }
	public static bool IsEmpty(string InString) { return default; }
	public static string GetSubstring(string SourceString,int StartIndex/*=0*/,int Length/*=1*/) { return default; }
	public static int FindSubstring(string SearchIn,string Substring,bool bUseCase/*=false*/,bool bSearchFromEnd/*=false*/,int StartPosition/*=-1*/) { return default; }
	public static bool Contains(string SearchIn,string Substring,bool bUseCase/*=false*/,bool bSearchFromEnd/*=false*/) { return default; }
	public static int GetCharacterAsNumber(string SourceString,int Index/*=0*/) { return default; }
	public static TArray<string> ParseIntoArray(string SourceString,string Delimiter/*=new FString(TEXT(" "))*/,bool CullEmptyStrings/*=true*/) { return default; }
	public static string JoinStringArray(TArray<string> SourceArray,string Separator/*=new FString(TEXT(" "))*/) { return default; }
	public static TArray<string> GetCharacterArrayFromString(string SourceString) { return default; }
	public static string ToUpper(string SourceString) { return default; }
	public static string ToLower(string SourceString) { return default; }
	public static string LeftPad(string SourceString,int ChCount) { return default; }
	public static string RightPad(string SourceString,int ChCount) { return default; }
	public static bool IsNumeric(string SourceString) { return default; }
	public static bool StartsWith(string SourceString,string InPrefix,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/) { return default; }
	public static bool EndsWith(string SourceString,string InSuffix,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/) { return default; }
	public static bool MatchesWildcard(string SourceString,string Wildcard,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/) { return default; }
	public static string Trim(string SourceString) { return default; }
	public static string TrimTrailing(string SourceString) { return default; }
	public static int CullArray(string SourceString,TArray<string> InArray) { return default; }
	public static string Reverse(string SourceString) { return default; }
	public static string Replace(string SourceString,string From,string To,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/) { return default; }
	public static int ReplaceInline(string SourceString,string SearchText,string ReplacementText,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/) { return default; }
	public static bool Split(string SourceString,string InStr,string LeftS,string RightS,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/,ESearchDir SearchDir/*=ESearchDir.FromStart*/) { return default; }
	public static string Left(string SourceString,int Count) { return default; }
	public static string LeftChop(string SourceString,int Count) { return default; }
	public static string Right(string SourceString,int Count) { return default; }
	public static string RightChop(string SourceString,int Count) { return default; }
	public static string Mid(string SourceString,int Start,int Count) { return default; }
	public static string TimeSecondsToString(float InSeconds) { return default; }
}
