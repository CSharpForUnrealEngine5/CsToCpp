#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithContentBlueprintLibrary.h")]
public partial class UDatasmithContentBlueprintLibrary : UBlueprintFunctionLibrary {
// DatasmithContentBlueprintLibrary
	public static UDatasmithAssetUserData GetDatasmithUserData(UObject Object) { return default; }
	public static string GetDatasmithUserDataValueForKey(UObject Object,string Key,bool bPartialMatchKey/*=false*/) { return default; }
	public static TArray<string> GetDatasmithUserDataValuesForKey(UObject Object,string Key,bool bPartialMatchKey/*=false*/) { return default; }
	public static void GetDatasmithUserDataKeysAndValuesForValue(UObject Object,string StringToMatch,TArray<string> OutKeys,TArray<string> OutValues) {}
	public static void GetAllDatasmithUserData(UClass ObjectClass,TArray<UDatasmithAssetUserData> OutUserData) {}
	public static void GetAllObjectsAndValuesForKey(string Key,UClass ObjectClass,TArray<UObject> OutObjects,TArray<string> OutValues) {}
}
