#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("JsonBlueprintFunctionLibrary.h")]
public partial class UJsonBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// JsonBlueprintFunctionLibrary
	public bool FromString(UObject WorldContextObject,string JsonString,FJsonObjectWrapper OutJsonObject) { return default; }
	public bool FromFile(UObject WorldContextObject,FFilePath File,FJsonObjectWrapper OutJsonObject) { return default; }
	public bool ToString(FJsonObjectWrapper JsonObject,string OutJsonString) { return default; }
	public bool ToFile(FJsonObjectWrapper JsonObject,FFilePath File) { return default; }
	public bool GetField(FJsonObjectWrapper JsonObject,string FieldName,int OutValue) { return default; }
	public bool SetField(FJsonObjectWrapper JsonObject,string FieldName,int Value) { return default; }
	public bool StructToJsonString(int Struct,string OutJsonString) { return default; }
	public bool HasField(FJsonObjectWrapper JsonObject,string FieldName) { return default; }
	public bool GetFieldNames(FJsonObjectWrapper JsonObject,TArray<string> FieldNames) { return default; }
}
