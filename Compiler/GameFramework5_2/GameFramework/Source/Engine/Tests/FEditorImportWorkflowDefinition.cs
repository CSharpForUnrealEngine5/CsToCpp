#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds settings for the asset import workflow test</summary>
[CppInclude("Tests/AutomationTestSettings.h")]
public partial struct FEditorImportWorkflowDefinition {
	public FFilePath ImportFilePath;
	public TArray<FImportFactorySettingValues> FactorySettings;
}
