#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>On each static mesh or actor to process, replace the material found in the first column of the table with the one from the second column in the same row</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSubstituteMaterialByTableOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Data table to use for the substitution</summary>
	public UDataTable MaterialDataTable;
}
