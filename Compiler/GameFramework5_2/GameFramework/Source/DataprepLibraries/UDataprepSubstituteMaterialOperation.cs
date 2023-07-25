#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepOperations.h")]
///<summary>On each static mesh or actor to process, replace the material matching the criteria with the specified one</summary>
public partial class UDataprepSubstituteMaterialOperation : UDataprepOperation {
// DataprepSubstituteMaterialOperation
	public string MaterialSearch;
	public EEditorScriptingStringMatchType StringMatch;
	public UMaterialInterface MaterialSubstitute;
}
