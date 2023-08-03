#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all factories</summary>
[CppInclude("Factories/Factory.h")]
public partial class UFactory : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether the specified file can be imported by this factory. (Implemented in script)</summary>
	public  bool ScriptFactoryCanImport(string Filename) { return default; }
	///<summary>Import object(s) using a task via script</summary>
	public  bool ScriptFactoryCreateFile(UAssetImportTask InTask) { return default; }
	///<summary>The default value to return from CanCreateNew()</summary>
	public bool bCreateNew;
	///<summary>The class manufactured by this factory.</summary>
	public UClass SupportedClass;
	///<summary>Class of the context object used to help create the object.</summary>
	public UClass ContextClass;
	///<summary>List of formats supported by the factory. Each entry is of the form &quot;ext;Description&quot; where ext is the file extension.</summary>
	public TArray<string> Formats;
	///<summary>true if the associated editor should be opened after creating a new object.</summary>
	public bool bEditAfterNew;
	///<summary>true if the factory imports objects from files.</summary>
	public bool bEditorImport;
	///<summary>true if the factory imports objects from text.</summary>
	public bool bText;
	///<summary>Determines the order in which factories are tried when importing or reimporting an object.</summary>
	public int ImportPriority;
	///<summary>Data for how to import files via the automated command line importing interface</summary>
	public UAutomatedAssetImportData AutomatedImportData;
	///<summary>Task for importing file via script interfaces</summary>
	public UAssetImportTask AssetImportTask;
	///<summary>For interactive object imports, this value indicates whether the user wants</summary>
	public int OverwriteYesOrNoToAllState;
}
