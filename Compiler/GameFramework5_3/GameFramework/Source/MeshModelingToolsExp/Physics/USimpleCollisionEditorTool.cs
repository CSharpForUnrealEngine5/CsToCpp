namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Collision Editing tool for updating the simple collision geometry on meshes</summary>
[CppInclude("Physics/SimpleCollisionEditorTool.h")]
public partial class USimpleCollisionEditorTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>ActionProperties</summary>
	public USimpleCollisionEditorToolActionProperties ActionProperties;
}
