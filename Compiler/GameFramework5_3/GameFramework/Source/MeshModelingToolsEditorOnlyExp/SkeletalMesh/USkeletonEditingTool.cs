namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USkeletonEditingTool is a tool to edit a the ReferenceSkeleton of a SkeletalMesh (target)</summary>
[CppInclude("SkeletalMesh/SkeletonEditingTool.h")]
public partial class USkeletonEditingTool : USingleSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>Modifier</summary>
	public USkeletonModifier Modifier;
	///<summary>Properties</summary>
	public USkeletonEditingProperties Properties;
	///<summary>ProjectionProperties</summary>
	public UProjectionProperties ProjectionProperties;
	///<summary>MirroringProperties</summary>
	public UMirroringProperties MirroringProperties;
	///<summary>OrientingProperties</summary>
	public UOrientingProperties OrientingProperties;
	///<summary>LeftClickBehavior</summary>
	public USingleClickInputBehavior LeftClickBehavior;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>TargetWorld</summary>
	public TWeakObjectPtr<UWorld> TargetWorld;
	///<summary>ViewContext</summary>
	public TWeakObjectPtr<UGizmoViewContext> ViewContext;
	///<summary>Operation</summary>
	public EEditingOperation Operation;
	///<summary>gizmo</summary>
	public TWeakObjectPtr<USkeletalMeshGizmoContextObjectBase> GizmoContext;
	///<summary>GizmoWrapper</summary>
	public USkeletalMeshGizmoWrapperBase GizmoWrapper;
	///<summary>EditorContext</summary>
	public TWeakObjectPtr<USkeletalMeshEditorContextObjectBase> EditorContext;
}
