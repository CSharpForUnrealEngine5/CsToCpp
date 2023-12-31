namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>API for dealing with mode-level selection in the UV editor.</summary>
[CppInclude("Selection/UVToolSelectionAPI.h")]
public partial class UUVToolSelectionAPI : UUVToolContextObject {
	public static UClass StaticClass() {return default;}
	///<summary>Targets</summary>
	public TArray<UUVEditorToolMeshInput> Targets;
	///<summary>MechanicAdapter</summary>
	public UUVEditorMechanicAdapterTool MechanicAdapter;
	///<summary>HighlightMechanic</summary>
	public UUVToolSelectionHighlightMechanic HighlightMechanic;
	///<summary>SelectionMechanic</summary>
	public UUVEditorMeshSelectionMechanic SelectionMechanic;
	///<summary>EmitChangeAPI</summary>
	public UUVToolEmitChangeAPI EmitChangeAPI;
}
