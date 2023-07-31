#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>On each actor to process set metadata value</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetMetadataOperation : UDataprepOperation {
	///<summary>Array of metadata values</summary>
	public TMap<string,string> Metadata;
}
