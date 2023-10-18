namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each static mesh to process, replace the existing static mesh&#39;s LODs with new ones based on the set of reduction settings</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetLODsOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>If true, the screen sizes at which LODs swap are automatically computed</summary>
	public bool bAutoComputeLODScreenSize;
	///<summary>Array of LOD reduction settings</summary>
	public TArray<FDataprepSetLODsReductionSettings> ReductionSettings;
}
