namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetStringLibrary.h")]
public partial class UKismetStringLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Converts a double value to a string</summary>
	public static string Conv_DoubleToString(double InDouble) { return default; }
	///<summary>Converts an integer value to a string</summary>
	public static string Conv_IntToString(int InInt) { return default; }
	///<summary>Converts an 64-bit integer value to a string</summary>
	public static string Conv_Int64ToString(long InInt) { return default; }
	///<summary>Converts a byte value to a string</summary>
	public static string Conv_ByteToString(byte InByte) { return default; }
	///<summary>Converts a boolean value to a string, either &#39;true&#39; or &#39;false&#39;</summary>
	public static string Conv_BoolToString(bool InBool) { return default; }
	///<summary>Converts a vector value to a string, in the form &#39;X= Y= Z=&#39;</summary>
	public static string Conv_VectorToString(FVector InVec) { return default; }
	///<summary>Converts a float vector value to a string, in the form &#39;X= Y= Z=&#39;</summary>
	public static string Conv_Vector3fToString(FVector3f InVec) { return default; }
	///<summary>Converts an IntVector value to a string, in the form &#39;X= Y= Z=&#39;</summary>
	public static string Conv_IntVectorToString(FIntVector InIntVec) { return default; }
	///<summary>Converts an IntPoint value to a string, in the form &#39;X= Y=&#39;</summary>
	public static string Conv_IntPointToString(FIntPoint InIntPoint) { return default; }
	///<summary>Converts a vector2d value to a string, in the form &#39;X= Y=&#39;</summary>
	public static string Conv_Vector2dToString(FVector2D InVec) { return default; }
	///<summary>Converts a rotator value to a string, in the form &#39;P= Y= R=&#39;</summary>
	public static string Conv_RotatorToString(FRotator InRot) { return default; }
	///<summary>Converts a transform value to a string, in the form &#39;Translation: X= Y= Z= Rotation: P= Y= R= Scale: X= Y= Z=&#39;</summary>
	public static string Conv_TransformToString(FTransform InTrans) { return default; }
	///<summary>Converts a UObject value to a string by calling the object&#39;s GetName method</summary>
	public static string Conv_ObjectToString(UObject InObj) { return default; }
	///<summary>Converts a InputDeviceId value to a string</summary>
	public static string Conv_InputDeviceIdToString(FInputDeviceId InDeviceId) { return default; }
	///<summary>Converts a PlatformUserId value to a string</summary>
	public static string Conv_PlatformUserIdToString(FPlatformUserId InPlatformUserId) { return default; }
	///<summary>Converts a linear color value to a string, in the form &#39;(R=,G=,B=,A=)&#39;</summary>
	public static string Conv_ColorToString(FLinearColor InColor) { return default; }
	///<summary>Converts a name value to a string</summary>
	public static string Conv_NameToString(string InName) { return default; }
	///<summary>Converts a name value to a string</summary>
	public static string Conv_MatrixToString(FMatrix InMatrix) { return default; }
	///<summary>Converts a string to a name value</summary>
	public static string Conv_StringToName(string InString) { return default; }
	///<summary>Converts a string to a int value</summary>
	public static int Conv_StringToInt(string InString) { return default; }
	///<summary>Converts a string to a int value</summary>
	public static long Conv_StringToInt64(string InString) { return default; }
	///<summary>Converts a string to a double value</summary>
	public static double Conv_StringToDouble(string InString) { return default; }
	///<summary>Convert String Back To Vector. IsValid indicates whether or not the string could be successfully converted.</summary>
	public static void Conv_StringToVector(string InString,FVector OutConvertedVector,bool OutIsValid) {}
	///<summary>Convert String Back To Float Vector. IsValid indicates whether or not the string could be successfully converted.</summary>
	public static void Conv_StringToVector3f(string InString,FVector3f OutConvertedVector,bool OutIsValid) {}
	///<summary>Convert String Back To Vector2D. IsValid indicates whether or not the string could be successfully converted.</summary>
	public static void Conv_StringToVector2D(string InString,FVector2D OutConvertedVector2D,bool OutIsValid) {}
	///<summary>Convert String Back To Rotator. IsValid indicates whether or not the string could be successfully converted.</summary>
	public static void Conv_StringToRotator(string InString,FRotator OutConvertedRotator,bool OutIsValid) {}
	///<summary>Convert String Back To Color. IsValid indicates whether or not the string could be successfully converted.</summary>
	public static void Conv_StringToColor(string InString,FLinearColor OutConvertedColor,bool OutIsValid) {}
	///<summary>Converts a double-&gt;string, create a new string in the form AppendTo+Prefix+InDouble+Suffix</summary>
	public static string BuildString_Double(string AppendTo,string Prefix,double InDouble,string Suffix) { return default; }
	///<summary>Converts a int-&gt;string, creating a new string in the form AppendTo+Prefix+InInt+Suffix</summary>
	public static string BuildString_Int(string AppendTo,string Prefix,int InInt,string Suffix) { return default; }
	///<summary>Converts a boolean-&gt;string, creating a new string in the form AppendTo+Prefix+InBool+Suffix</summary>
	public static string BuildString_Bool(string AppendTo,string Prefix,bool InBool,string Suffix) { return default; }
	///<summary>Converts a vector-&gt;string, creating a new string in the form AppendTo+Prefix+InVector+Suffix</summary>
	public static string BuildString_Vector(string AppendTo,string Prefix,FVector InVector,string Suffix) { return default; }
	///<summary>Converts an IntVector-&gt;string, creating a new string in the form AppendTo+Prefix+InIntVector+Suffix</summary>
	public static string BuildString_IntVector(string AppendTo,string Prefix,FIntVector InIntVector,string Suffix) { return default; }
	///<summary>Converts a vector2d-&gt;string, creating a new string in the form AppendTo+Prefix+InVector2d+Suffix</summary>
	public static string BuildString_Vector2d(string AppendTo,string Prefix,FVector2D InVector2d,string Suffix) { return default; }
	///<summary>Converts a rotator-&gt;string, creating a new string in the form AppendTo+Prefix+InRot+Suffix</summary>
	public static string BuildString_Rotator(string AppendTo,string Prefix,FRotator InRot,string Suffix) { return default; }
	///<summary>Converts a object-&gt;string, creating a new string in the form AppendTo+Prefix+object name+Suffix</summary>
	public static string BuildString_Object(string AppendTo,string Prefix,UObject InObj,string Suffix) { return default; }
	///<summary>Converts a color-&gt;string, creating a new string in the form AppendTo+Prefix+InColor+Suffix</summary>
	public static string BuildString_Color(string AppendTo,string Prefix,FLinearColor InColor,string Suffix) { return default; }
	///<summary>Converts a color-&gt;string, creating a new string in the form AppendTo+Prefix+InName+Suffix</summary>
	public static string BuildString_Name(string AppendTo,string Prefix,string InName,string Suffix) { return default; }
	///<summary>Concatenates two strings together to make a new string</summary>
	public static string Concat_StrStr(string A,string B) { return default; }
	///<summary>Test if the input strings are equal (A == B)</summary>
	public static bool EqualEqual_StrStr(string A,string B) { return default; }
	///<summary>Test if the input strings are equal (A == B), ignoring case</summary>
	public static bool EqualEqual_StriStri(string A,string B) { return default; }
	///<summary>Test if the input string are not equal (A != B)</summary>
	public static bool NotEqual_StrStr(string A,string B) { return default; }
	///<summary>Test if the input string are not equal (A != B), ignoring case differences</summary>
	public static bool NotEqual_StriStri(string A,string B) { return default; }
	///<summary>Returns the number of characters in the string</summary>
	public static int Len(string S) { return default; }
	///<summary>Returns true if the string is empty</summary>
	public static bool IsEmpty(string InString) { return default; }
	///<summary>Returns a substring from the string starting at the specified position</summary>
	public static string GetSubstring(string SourceString,int StartIndex/*=0*/,int Length/*=1*/) { return default; }
	///<summary>Finds the starting index of a substring in the a specified string</summary>
	public static int FindSubstring(string SearchIn,string Substring,bool bUseCase/*=false*/,bool bSearchFromEnd/*=false*/,int StartPosition/*=-1*/) { return default; }
	///<summary>Returns whether this string contains the specified substring.</summary>
	public static bool Contains(string SearchIn,string Substring,bool bUseCase/*=false*/,bool bSearchFromEnd/*=false*/) { return default; }
	///<summary>Gets a single character from the string (as an integer)</summary>
	public static int GetCharacterAsNumber(string SourceString,int Index/*=0*/) { return default; }
	///<summary>Gets an array of strings from a source string divided up by a separator and empty strings can optionally be culled.</summary>
	public static TArray<string> ParseIntoArray(string SourceString,string Delimiter/*=new FString(TEXT(" "))*/,bool CullEmptyStrings/*=true*/) { return default; }
	///<summary>Concatenates an array of strings into a single string.</summary>
	public static string JoinStringArray(TArray<string> SourceArray,string Separator/*=new FString(TEXT(" "))*/) { return default; }
	///<summary>Returns an array that contains one entry for each character in SourceString</summary>
	public static TArray<string> GetCharacterArrayFromString(string SourceString) { return default; }
	///<summary>Returns a string converted to Upper case</summary>
	public static string ToUpper(string SourceString) { return default; }
	///<summary>Returns a string converted to Lower case</summary>
	public static string ToLower(string SourceString) { return default; }
	///<summary>* Pad the left of this string for a specified number of characters</summary>
	public static string LeftPad(string SourceString,int ChCount) { return default; }
	///<summary>* Pad the right of this string for a specified number of characters</summary>
	public static string RightPad(string SourceString,int ChCount) { return default; }
	///<summary>* Checks if a string contains only numeric characters</summary>
	public static bool IsNumeric(string SourceString) { return default; }
	///<summary>Test whether this string starts with given string.</summary>
	public static bool StartsWith(string SourceString,string InPrefix,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/) { return default; }
	///<summary>Test whether this string ends with given string.</summary>
	public static bool EndsWith(string SourceString,string InSuffix,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/) { return default; }
	///<summary>Searches this string for a given wild card</summary>
	public static bool MatchesWildcard(string SourceString,string Wildcard,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/) { return default; }
	///<summary>Removes whitespace characters from the front of this string.</summary>
	public static string Trim(string SourceString) { return default; }
	///<summary>Removes trailing whitespace characters</summary>
	public static string TrimTrailing(string SourceString) { return default; }
	///<summary>Takes an array of strings and removes any zero length entries.</summary>
	public static int CullArray(string SourceString,TArray<string> InArray) { return default; }
	///<summary>Returns a copy of this string, with the characters in reverse order</summary>
	public static string Reverse(string SourceString) { return default; }
	///<summary>Replace all occurrences of a substring in this string</summary>
	public static string Replace(string SourceString,string From,string To,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/) { return default; }
	///<summary>Replace all occurrences of SearchText with ReplacementText in this string.</summary>
	public static int ReplaceInline(string SourceString,string SearchText,string ReplacementText,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/) { return default; }
	///<summary>Splits this string at given string position case sensitive.</summary>
	public static bool Split(string SourceString,string InStr,string LeftS,string RightS,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/,ESearchDir SearchDir/*=ESearchDir.FromStart*/) { return default; }
	///<summary>Returns the left most given number of characters</summary>
	public static string Left(string SourceString,int Count) { return default; }
	///<summary>Returns the left most characters from the string chopping the given number of characters from the end</summary>
	public static string LeftChop(string SourceString,int Count) { return default; }
	///<summary>Returns the string to the right of the specified location, counting back from the right (end of the word).</summary>
	public static string Right(string SourceString,int Count) { return default; }
	///<summary>Returns the string to the right of the specified location, counting forward from the left (from the beginning of the word).</summary>
	public static string RightChop(string SourceString,int Count) { return default; }
	///<summary>Returns the substring from Start position for Count characters.</summary>
	public static string Mid(string SourceString,int Start,int Count) { return default; }
	///<summary>Convert a number of seconds into minutes:seconds.milliseconds format string (including leading zeroes)</summary>
	public static string TimeSecondsToString(float InSeconds) { return default; }
}
