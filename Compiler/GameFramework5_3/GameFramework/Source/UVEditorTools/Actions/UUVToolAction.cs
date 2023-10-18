namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Actions/UVToolAction.h")]
public partial class UUVToolAction : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SelectionAPI</summary>
	public UUVToolSelectionAPI SelectionAPI;
	///<summary>EmitChangeAPI</summary>
	public UUVToolEmitChangeAPI EmitChangeAPI;
}
