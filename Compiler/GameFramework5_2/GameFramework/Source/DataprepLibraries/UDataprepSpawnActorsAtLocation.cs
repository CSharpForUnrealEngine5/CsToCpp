#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each actor in the input set, spawn an actor from the specified Asset at the same position and orientation than the reference</summary>
[CppInclude("DataprepEditingOperations.h")]
public partial class UDataprepSpawnActorsAtLocation : UDataprepEditingOperation {
	public static UClass StaticClass() {return default;}
	///<summary>SelectedAsset</summary>
	public UObject SelectedAsset;
}
