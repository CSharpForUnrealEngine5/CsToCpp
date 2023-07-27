#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/Factory.h")]
///<summary>Base class for all factories</summary>
public partial class UFactory : UObject {
// Factory
	public  bool ScriptFactoryCanImport(string Filename) { return default; }
	public  bool ScriptFactoryCreateFile(UAssetImportTask InTask) { return default; }
	public bool bCreateNew;
	public UClass SupportedClass;
	public UClass ContextClass;
	public TArray<string> Formats;
	public bool bEditAfterNew;
	public bool bEditorImport;
	public bool bText;
	public int ImportPriority;
	public UAutomatedAssetImportData AutomatedImportData;
	public UAssetImportTask AssetImportTask;
	public int OverwriteYesOrNoToAllState;
}
