#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>On each static mesh or actor to process, replace any materials used with the specified one</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetMaterialOperation : UDataprepOperation {
	///<summary>Material to use as a substitute</summary>
	public UMaterialInterface Material;
}
