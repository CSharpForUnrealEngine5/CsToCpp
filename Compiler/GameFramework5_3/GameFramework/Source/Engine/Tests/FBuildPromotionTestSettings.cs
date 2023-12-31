namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds settings for the editor build promotion test</summary>
[CppInclude("Tests/AutomationTestSettings.h")]
public partial struct FBuildPromotionTestSettings {
	public FFilePath DefaultStaticMeshAsset;
	public FBuildPromotionImportWorkflowSettings ImportWorkflow;
	public FBuildPromotionOpenAssetSettings OpenAssets;
	public FBuildPromotionNewProjectSettings NewProjectSettings;
	public FFilePath SourceControlMaterial;
}
