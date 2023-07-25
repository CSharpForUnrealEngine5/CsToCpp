#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraTypes.h")]
///<summary>Can convert struct data from custom structs containing LWC data such as FVector3d into struct data suitable for Niagara simulations and vice versa.</summary>
public partial struct FNiagaraLwcStructConverter {
// NiagaraLwcStructConverter
	public int LWCSize;
	public int SWCSize;
	public TArray<FNiagaraStructConversionStep> ConversionSteps;
}
