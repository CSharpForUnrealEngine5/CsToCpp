#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepOperationsLibrary.h")]
///<summary>* Simple struct for the table row used for UDataprepOperationsLibrary::SubstituteMaterials</summary>
public partial struct FMaterialSubstitutionDataTable {
// MaterialSubstitutionDataTable
	public string SearchString;
	public EEditorScriptingStringMatchType StringMatch;
	public UMaterialInterface MaterialReplacement;
}
