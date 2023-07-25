#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceRW.h")]
public partial class UNiagaraDataInterfaceGrid3D : UNiagaraDataInterfaceRWBase {
// NiagaraDataInterfaceGrid3D
	public bool ClearBeforeNonIterationStage;
	public FIntVector NumCells;
	public float CellSize;
	public int NumCellsMaxAxis;
	public ESetResolutionMethod SetResolutionMethod;
	public FVector WorldBBoxSize;
}
