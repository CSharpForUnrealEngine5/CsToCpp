#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each asset to process, set the sub-folder to save it to.</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetOutputFolder : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the sub folder the assets to be saved to</summary>
	public string FolderName;
}
