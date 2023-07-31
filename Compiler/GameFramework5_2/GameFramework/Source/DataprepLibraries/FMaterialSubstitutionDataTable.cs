#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Simple struct for the table row used for UDataprepOperationsLibrary::SubstituteMaterials</summary>
[CppInclude("DataprepOperationsLibrary.h")]
public partial struct FMaterialSubstitutionDataTable {
	public string SearchString;
	public EEditorScriptingStringMatchType StringMatch;
	public UMaterialInterface MaterialReplacement;
}
