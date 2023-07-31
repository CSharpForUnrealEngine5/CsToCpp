#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Single Selection Mesh Editing tool base class.</summary>
[CppInclude("BaseTools/SingleSelectionMeshEditingTool.h")]
public partial class USingleSelectionMeshEditingTool : USingleSelectionTool {
	///<summary>TargetWorld</summary>
	public TWeakObjectPtr<UWorld> TargetWorld;
	///<summary>InputSelection_DEPRECATED</summary>
	public UDEPRECATED_PersistentMeshSelection InputSelection_DEPRECATED;
}
