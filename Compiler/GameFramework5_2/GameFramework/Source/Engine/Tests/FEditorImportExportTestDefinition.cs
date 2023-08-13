namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds settings for the asset import / export automation test</summary>
[CppInclude("Tests/AutomationTestSettings.h")]
public partial struct FEditorImportExportTestDefinition {
	public FFilePath ImportFilePath;
	public string ExportFileExtension;
	public bool bSkipExport;
	public TArray<FImportFactorySettingValues> FactorySettings;
}
