namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USingleClickTool is perhaps the simplest possible interactive tool. It simply</summary>
[CppInclude("MeshSelect.h")]
public partial class UMeshClickTool : USingleClickTool {
	public static UClass StaticClass() {return default;}
	///<summary>SelectionMechanic</summary>
	public UMeshPaintSelectionMechanic SelectionMechanic;
}
