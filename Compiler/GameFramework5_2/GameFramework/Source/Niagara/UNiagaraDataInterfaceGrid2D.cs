#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceRW.h")]
public partial class UNiagaraDataInterfaceGrid2D : UNiagaraDataInterfaceRWBase {
// NiagaraDataInterfaceGrid2D
	public bool ClearBeforeNonIterationStage;
	public int NumCellsX;
	public int NumCellsY;
	public int NumCellsMaxAxis;
	public int NumAttributes;
	public bool SetGridFromMaxAxis;
	public FVector2D WorldBBoxSize;
}
