#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraParameterCollection.h")]
///<summary>Asset containing a collection of global parameters usable by Niagara.</summary>
public partial class UNiagaraParameterCollection : UObject {
// NiagaraParameterCollection
	public string Namespace;
	public TArray<FNiagaraVariable> Parameters;
	public UMaterialParameterCollection SourceMaterialCollection;
	public UNiagaraParameterCollectionInstance DefaultInstance;
	public FGuid CompileId;
}
