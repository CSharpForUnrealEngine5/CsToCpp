namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An interactive tool for painting and editing skin weights.</summary>
[CppInclude("SkeletalMesh/SkinWeightsPaintTool.h")]
public partial class USkinWeightsPaintTool : UDynamicMeshBrushTool {
	public static UClass StaticClass() {return default;}
	///<summary>tool properties</summary>
	public USkinWeightsPaintToolProperties WeightToolProperties;
	///<summary>polygon selection mechanic</summary>
	public UPolygonSelectionMechanic PolygonSelectionMechanic;
	///<summary>EditorContext</summary>
	public TWeakObjectPtr<USkeletalMeshEditorContextObjectBase> EditorContext;
}
