namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>On each actor to process set metadata value</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetMetadataOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Array of metadata values</summary>
	public TMap<FName,string> Metadata;
}
