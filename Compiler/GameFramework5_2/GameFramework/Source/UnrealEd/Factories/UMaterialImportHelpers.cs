namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/MaterialImportHelpers.h")]
public partial class UMaterialImportHelpers : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FindExistingMaterialFromSearchLocation</summary>
	public static UMaterialInterface FindExistingMaterialFromSearchLocation(string MaterialFullName,string BasePackagePath,EMaterialSearchLocation SearchLocation,FText OutError) { return default; }
	///<summary>FindExistingMaterial</summary>
	public static UMaterialInterface FindExistingMaterial(string BasePath,string MaterialFullName,bool bRecursivePaths,FText OutError) { return default; }
}
