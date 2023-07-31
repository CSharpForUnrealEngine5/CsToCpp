#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>On each static mesh or actor to process, replace the material matching the criteria with the specified one</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSubstituteMaterialOperation : UDataprepOperation {
	///<summary>Name of the material(s) to search for. Wildcard is supported</summary>
	public string MaterialSearch;
	///<summary>Type of matching to perform with MaterialSearch string</summary>
	public EEditorScriptingStringMatchType StringMatch;
	///<summary>Material to use as a substitute</summary>
	public UMaterialInterface MaterialSubstitute;
}
