namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Single Selection Mesh Editing tool base class.</summary>
[CppInclude("BaseTools/SingleSelectionMeshEditingTool.h")]
public partial class USingleSelectionMeshEditingTool : USingleSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>TargetWorld</summary>
	public TWeakObjectPtr<UWorld> TargetWorld;
	///<summary>InputSelection_DEPRECATED</summary>
	public UDEPRECATED_PersistentMeshSelection InputSelection_DEPRECATED;
}
