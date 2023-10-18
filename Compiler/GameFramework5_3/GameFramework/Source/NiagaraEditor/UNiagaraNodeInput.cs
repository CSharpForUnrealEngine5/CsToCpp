namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeInput.h")]
public partial class UNiagaraNodeInput : UNiagaraNode {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FNiagaraVariable Input;
	///<summary>Usage</summary>
	public ENiagaraInputNodeUsage Usage;
	///<summary>Controls where this input is relative to others in the calling node.</summary>
	public int CallSortPriority;
	///<summary>Controls this inputs exposure to callers.</summary>
	public FNiagaraInputExposureOptions ExposureOptions;
	///<summary>DataInterface</summary>
	public UNiagaraDataInterface DataInterface;
	///<summary>ObjectAsset</summary>
	public UObject ObjectAsset;
}
