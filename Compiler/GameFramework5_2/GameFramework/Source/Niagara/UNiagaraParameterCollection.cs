#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset containing a collection of global parameters usable by Niagara.</summary>
[CppInclude("NiagaraParameterCollection.h")]
public partial class UNiagaraParameterCollection : UObject {
	///<summary>Namespace for this parameter collection. Is enforced to be unique across all parameter collections.</summary>
	public string Namespace;
	///<summary>Parameters</summary>
	public TArray<FNiagaraVariable> Parameters;
	///<summary>Optional set of MPC that can drive scalar and vector parameters</summary>
	public UMaterialParameterCollection SourceMaterialCollection;
	///<summary>DefaultInstance</summary>
	public UNiagaraParameterCollectionInstance DefaultInstance;
	///<summary>Used to track whenever something of note changes in this parameter collection that might invalidate a compilation downstream of a script/emitter/system.</summary>
	public FGuid CompileId;
}
