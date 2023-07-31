#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>API for dealing with mode-level selection in the UV editor.</summary>
[CppInclude("Selection/UVToolSelectionAPI.h")]
public partial class UUVToolSelectionAPI : UUVToolContextObject {
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
