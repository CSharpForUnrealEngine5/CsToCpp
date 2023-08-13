namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("JsonBlueprintFunctionLibrary.h")]
public partial class UJsonBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Creates a JsonObject from the provided Json string.</summary>
	public static bool FromString(UObject WorldContextObject,string JsonString,FJsonObjectWrapper OutJsonObject) { return default; }
	///<summary>Creates a JsonObject from the provided Json file.</summary>
	public static bool FromFile(UObject WorldContextObject,FFilePath File,FJsonObjectWrapper OutJsonObject) { return default; }
	///<summary>Creates a Json string from the provided JsonObject.</summary>
	public static bool ToString(FJsonObjectWrapper JsonObject,string OutJsonString) { return default; }
	///<summary>Creates a file from the provided JsonObject.</summary>
	public static bool ToFile(FJsonObjectWrapper JsonObject,FFilePath File) { return default; }
	///<summary>Gets the value of the specified field.</summary>
	public static bool GetField(FJsonObjectWrapper JsonObject,string FieldName,int OutValue) { return default; }
	///<summary>Adds (new) or sets (existing) the value of the specified field.</summary>
	public static bool SetField(FJsonObjectWrapper JsonObject,string FieldName,int Value) { return default; }
	///<summary>StructToJsonString</summary>
	public static bool StructToJsonString(int Struct,string OutJsonString) { return default; }
	///<summary>Checks if the field exists on the object.</summary>
	public static bool HasField(FJsonObjectWrapper JsonObject,string FieldName) { return default; }
	///<summary>Gets all field names on the JsonObject</summary>
	public static bool GetFieldNames(FJsonObjectWrapper JsonObject,TArray<string> FieldNames) { return default; }
}
