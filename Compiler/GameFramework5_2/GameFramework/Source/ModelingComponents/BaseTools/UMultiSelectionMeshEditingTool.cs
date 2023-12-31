namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Multi Selection Mesh Editing tool base class.</summary>
[CppInclude("BaseTools/MultiSelectionMeshEditingTool.h")]
public partial class UMultiSelectionMeshEditingTool : UMultiSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>TargetWorld</summary>
	public TWeakObjectPtr<UWorld> TargetWorld;
}
