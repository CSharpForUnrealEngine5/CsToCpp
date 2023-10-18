namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UStruct that holds a JsonObject, can be used by structs passed to JsonObjectConverter to pass through JsonObjects directly</summary>
[CppInclude("JsonObjectWrapper.h")]
public partial struct FJsonObjectWrapper {
	public string JsonString;
}
