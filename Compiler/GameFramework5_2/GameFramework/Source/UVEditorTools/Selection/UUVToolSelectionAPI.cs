#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Selection/UVToolSelectionAPI.h")]
///<summary>API for dealing with mode-level selection in the UV editor.</summary>
public partial class UUVToolSelectionAPI : UUVToolContextObject {
// UVToolSelectionAPI
	public TArray<UUVEditorToolMeshInput> Targets;
	public UUVEditorMechanicAdapterTool MechanicAdapter;
	public UUVToolSelectionHighlightMechanic HighlightMechanic;
	public UUVEditorMeshSelectionMechanic SelectionMechanic;
	public UUVToolEmitChangeAPI EmitChangeAPI;
}
