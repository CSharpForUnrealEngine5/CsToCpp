#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper struct for tracking parameters that are reserved by parameter definitions assets.</summary>
[CppInclude("NiagaraEditorModule.h")]
public partial struct FReservedParameter {
	public FNiagaraVariableBase Parameter;
	public UNiagaraParameterDefinitions ReservingDefinitionsAsset;
}
