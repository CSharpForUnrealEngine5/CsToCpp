namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UImportSubsystem</summary>
[CppInclude("Subsystems/ImportSubsystem.h")]
public partial class UImportSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>delegate type fired when new assets are being (re-)imported. Params: UFactory* InFactory, UClass* InClass, UObject* InParent, const FName&amp; Name, const TCHAR* Type</summary>
	public void FOnAssetPreImport_Dyn(UFactory InFactory,UClass InClass,UObject InParent,FName Name,string Type) {}
	///<summary>delegate type fired when new assets have been (re-)imported. Note: InCreatedObject can be NULL if import failed. Params: UFactory* InFactory, UObject* InCreatedObject</summary>
	public void FOnAssetPostImport_Dyn(UFactory InFactory,UObject InCreatedObject) {}
	///<summary>delegate type fired when new assets have been reimported. Note: InCreatedObject can be NULL if import failed. Params: UObject* InCreatedObject</summary>
	public void FOnAssetReimport_Dyn(UObject InCreatedObject) {}
	///<summary>delegate type fired when new LOD have been imported to an asset.</summary>
	public void FOnAssetPostLODImport_Dyn(UObject InObject,int InLODIndex) {}
	///<summary>OnAssetPreImport_BP</summary>
	public FOnAssetPreImport_Dyn OnAssetPreImport_BP;
	///<summary>OnAssetPostImport_BP</summary>
	public FOnAssetPostImport_Dyn OnAssetPostImport_BP;
	///<summary>OnAssetReimport_BP</summary>
	public FOnAssetReimport_Dyn OnAssetReimport_BP;
	///<summary>OnAssetPostLODImport_BP</summary>
	public FOnAssetPostLODImport_Dyn OnAssetPostLODImport_BP;
}
