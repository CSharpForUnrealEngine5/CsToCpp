#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseTools/SingleSelectionMeshEditingTool.h")]
///<summary>Single Selection Mesh Editing tool base class.</summary>
public partial class USingleSelectionMeshEditingTool : USingleSelectionTool {
// SingleSelectionMeshEditingTool
	public TWeakObjectPtr<UWorld> TargetWorld;
	public UDEPRECATED_PersistentMeshSelection InputSelection_DEPRECATED;
}
