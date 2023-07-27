#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Subsystems/ImportSubsystem.h")]
///<summary>UImportSubsystem</summary>
public partial class UImportSubsystem : UEditorSubsystem {
// ImportSubsystem
	public  void FOnAssetPreImport_Dyn(UFactory InFactory,UClass InClass,UObject InParent,string Name,string Type) {}
	public  void FOnAssetPostImport_Dyn(UFactory InFactory,UObject InCreatedObject) {}
	public  void FOnAssetReimport_Dyn(UObject InCreatedObject) {}
	public  void FOnAssetPostLODImport_Dyn(UObject InObject,int InLODIndex) {}
	public FOnAssetPreImport_Dyn OnAssetPreImport_BP;
	public FOnAssetPostImport_Dyn OnAssetPostImport_BP;
	public FOnAssetReimport_Dyn OnAssetReimport_BP;
	public FOnAssetPostLODImport_Dyn OnAssetPostLODImport_BP;
}
