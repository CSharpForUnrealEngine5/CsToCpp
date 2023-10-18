namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per-World Actor Folders UObject (used to support undo/redo reliably)</summary>
[CppInclude("WorldFolders.h")]
public partial class UWorldFolders : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CurrentFolder</summary>
	public FActorPlacementFolder CurrentFolder;
}
