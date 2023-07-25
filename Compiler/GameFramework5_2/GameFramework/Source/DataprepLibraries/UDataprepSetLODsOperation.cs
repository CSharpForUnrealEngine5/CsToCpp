#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepOperations.h")]
///<summary>For each static mesh to process, replace the existing static mesh's LODs with new ones based on the set of reduction settings</summary>
public partial class UDataprepSetLODsOperation : UDataprepOperation {
// DataprepSetLODsOperation
	public bool bAutoComputeLODScreenSize;
	public TArray<FDataprepSetLODsReductionSettings> ReductionSettings;
}
