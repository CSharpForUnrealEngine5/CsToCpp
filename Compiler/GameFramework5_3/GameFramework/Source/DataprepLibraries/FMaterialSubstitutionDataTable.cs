namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Simple struct for the table row used for UDataprepOperationsLibrary::SubstituteMaterials</summary>
[CppInclude("DataprepOperationsLibrary.h")]
public partial struct FMaterialSubstitutionDataTable {
	public string SearchString;
	public EEditorScriptingStringMatchType StringMatch;
	public UMaterialInterface MaterialReplacement;
}
