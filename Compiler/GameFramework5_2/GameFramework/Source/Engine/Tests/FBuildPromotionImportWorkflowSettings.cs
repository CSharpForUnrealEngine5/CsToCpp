#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/AutomationTestSettings.h")]
///<summary>Holds settings for the import workflow stage of the build promotion test</summary>
public partial struct FBuildPromotionImportWorkflowSettings {
// BuildPromotionImportWorkflowSettings
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
