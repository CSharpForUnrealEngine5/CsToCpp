namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds settings for the import workflow stage of the build promotion test</summary>
[CppInclude("Tests/AutomationTestSettings.h")]
public partial struct FBuildPromotionImportWorkflowSettings {
	public FEditorImportWorkflowDefinition Diffuse;
	public FEditorImportWorkflowDefinition Normal;
	public FEditorImportWorkflowDefinition StaticMesh;
	public FEditorImportWorkflowDefinition ReimportStaticMesh;
	public FEditorImportWorkflowDefinition BlendShapeMesh;
	public FEditorImportWorkflowDefinition MorphMesh;
	public FEditorImportWorkflowDefinition SkeletalMesh;
	public FEditorImportWorkflowDefinition Animation;
	public FEditorImportWorkflowDefinition Sound;
	public FEditorImportWorkflowDefinition SurroundSound;
	public TArray<FEditorImportWorkflowDefinition> OtherAssetsToImport;
}
