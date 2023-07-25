#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithContentBlueprintLibrary.h")]
public partial class UDatasmithContentBlueprintLibrary : UBlueprintFunctionLibrary {
// DatasmithContentBlueprintLibrary
	public UObject GetDatasmithUserData(UObject Object) { return default; }
	public string GetDatasmithUserDataValueForKey(UObject Object,string Key,bool bPartialMatchKey/*=false*/) { return default; }
	public TArray<string> GetDatasmithUserDataValuesForKey(UObject Object,string Key,bool bPartialMatchKey/*=false*/) { return default; }
	public void GetDatasmithUserDataKeysAndValuesForValue(UObject Object,string StringToMatch,TArray<string> OutKeys,TArray<string> OutValues) {}
	public void GetAllDatasmithUserData(UClass ObjectClass,TArray<UObject> OutUserData) {}
	public void GetAllObjectsAndValuesForKey(string Key,UClass ObjectClass,TArray<UObject> OutObjects,TArray<string> OutValues) {}
}
