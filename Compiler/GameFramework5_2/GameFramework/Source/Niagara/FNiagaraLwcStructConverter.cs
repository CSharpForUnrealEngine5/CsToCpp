namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Can convert struct data from custom structs containing LWC data such as FVector3d into struct data suitable for Niagara simulations and vice versa.</summary>
[CppInclude("NiagaraTypes.h")]
public partial struct FNiagaraLwcStructConverter {
	public int LWCSize;
	public int SWCSize;
	public TArray<FNiagaraStructConversionStep> ConversionSteps;
}
