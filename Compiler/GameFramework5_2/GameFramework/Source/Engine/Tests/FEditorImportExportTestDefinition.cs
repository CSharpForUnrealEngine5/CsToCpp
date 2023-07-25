#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/AutomationTestSettings.h")]
///<summary>Holds settings for the asset import / export automation test</summary>
public partial struct FEditorImportExportTestDefinition {
// EditorImportExportTestDefinition
	public FFilePath ImportFilePath;
	public string ExportFileExtension;
	public bool bSkipExport;
	public TArray<FImportFactorySettingValues> FactorySettings;
}
