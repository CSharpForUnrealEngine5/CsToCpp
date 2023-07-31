#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per-World Actor Folders UObject (used to support undo/redo reliably)</summary>
[CppInclude("WorldFolders.h")]
public partial class UWorldFolders : UObject {
	///<summary>CurrentFolder</summary>
	public FActorPlacementFolder CurrentFolder;
}
