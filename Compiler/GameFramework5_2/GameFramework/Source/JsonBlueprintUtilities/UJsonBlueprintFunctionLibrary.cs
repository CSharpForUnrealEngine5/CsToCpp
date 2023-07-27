#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("JsonBlueprintFunctionLibrary.h")]
public partial class UJsonBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// JsonBlueprintFunctionLibrary
	public static bool FromString(UObject WorldContextObject,string JsonString,FJsonObjectWrapper OutJsonObject) { return default; }
	public static bool FromFile(UObject WorldContextObject,FFilePath File,FJsonObjectWrapper OutJsonObject) { return default; }
	public static bool ToString(FJsonObjectWrapper JsonObject,string OutJsonString) { return default; }
	public static bool ToFile(FJsonObjectWrapper JsonObject,FFilePath File) { return default; }
	public static bool GetField(FJsonObjectWrapper JsonObject,string FieldName,int OutValue) { return default; }
	public static bool SetField(FJsonObjectWrapper JsonObject,string FieldName,int Value) { return default; }
	public static bool StructToJsonString(int Struct,string OutJsonString) { return default; }
	public static bool HasField(FJsonObjectWrapper JsonObject,string FieldName) { return default; }
	public static bool GetFieldNames(FJsonObjectWrapper JsonObject,TArray<string> FieldNames) { return default; }
}
