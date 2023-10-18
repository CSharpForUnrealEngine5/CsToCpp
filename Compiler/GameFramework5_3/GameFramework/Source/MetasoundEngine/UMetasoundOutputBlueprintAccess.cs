namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint support for core types. If you want to support more core types, add them here.</summary>
[CppInclude("MetasoundOutput.h")]
public partial class UMetasoundOutputBlueprintAccess : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>IsFloat</summary>
	public static bool IsFloat(FMetaSoundOutput Output) { return default; }
	///<summary>GetFloat</summary>
	public static float GetFloat(FMetaSoundOutput Output,bool Success) { return default; }
	///<summary>IsInt32</summary>
	public static bool IsInt32(FMetaSoundOutput Output) { return default; }
	///<summary>GetInt32</summary>
	public static int GetInt32(FMetaSoundOutput Output,bool Success) { return default; }
	///<summary>IsBool</summary>
	public static bool IsBool(FMetaSoundOutput Output) { return default; }
	///<summary>GetBool</summary>
	public static bool GetBool(FMetaSoundOutput Output,bool Success) { return default; }
	///<summary>IsString</summary>
	public static bool IsString(FMetaSoundOutput Output) { return default; }
	///<summary>GetString</summary>
	public static string GetString(FMetaSoundOutput Output,bool Success) { return default; }
	///<summary>IsTime</summary>
	public static bool IsTime(FMetaSoundOutput Output) { return default; }
	///<summary>GetTimeSeconds</summary>
	public static float GetTimeSeconds(FMetaSoundOutput Output,bool Success) { return default; }
}
