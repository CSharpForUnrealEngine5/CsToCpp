#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEditorModule.h")]
///<summary>Wrapper struct for tracking parameters that are reserved by parameter definitions assets.</summary>
public partial struct FReservedParameter {
// ReservedParameter
	public FNiagaraVariableBase Parameter;
	public UNiagaraParameterDefinitions ReservingDefinitionsAsset;
}
