#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each static mesh to process, replace the existing static mesh&#39;s LODs with new ones based on the set of reduction settings</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetLODsOperation : UDataprepOperation {
	///<summary>If true, the screen sizes at which LODs swap are automatically computed</summary>
	public bool bAutoComputeLODScreenSize;
	///<summary>Array of LOD reduction settings</summary>
	public TArray<FDataprepSetLODsReductionSettings> ReductionSettings;
}
