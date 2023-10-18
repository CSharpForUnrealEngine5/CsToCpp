namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithContentBlueprintLibrary.h")]
public partial class UDatasmithContentBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get the Datasmith User Data of a given object</summary>
	public static UDatasmithAssetUserData GetDatasmithUserData(UObject Object) { return default; }
	///<summary>Get the value of the given key for the Datasmith User Data of the given object.</summary>
	public static string GetDatasmithUserDataValueForKey(UObject Object,FName Key,bool bPartialMatchKey/*=false*/) { return default; }
	///<summary>Get the values of the given key for the Datasmith User Data of the given object.</summary>
	public static TArray<string> GetDatasmithUserDataValuesForKey(UObject Object,FName Key,bool bPartialMatchKey/*=false*/) { return default; }
	///<summary>Get the keys and values for which the associated value contains the string to match for the Datasmith User Data of the given object.</summary>
	public static void GetDatasmithUserDataKeysAndValuesForValue(UObject Object,string StringToMatch,TArray<FName> OutKeys,TArray<string> OutValues) {}
	///<summary>Find all Datasmith User Data of loaded objects of the given type.</summary>
	public static void GetAllDatasmithUserData(UClass ObjectClass,TArray<UDatasmithAssetUserData> OutUserData) {}
	///<summary>Find all loaded objects of the given type that have a Datasmith User Data that contains the given key and their associated values.</summary>
	public static void GetAllObjectsAndValuesForKey(FName Key,UClass ObjectClass,TArray<UObject> OutObjects,TArray<string> OutValues) {}
}
