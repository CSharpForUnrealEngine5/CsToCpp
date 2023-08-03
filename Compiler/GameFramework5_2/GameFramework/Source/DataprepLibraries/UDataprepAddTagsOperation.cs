#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>On each actor to process, add specified tags</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepAddTagsOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Array of tags to add</summary>
	public TArray<string> Tags;
}
