#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeImportTestStepImport.h")]
public partial class UInterchangeImportTestStepImport : UInterchangeImportTestStepBase {
	///<summary>The source file to import (path relative to the json script)</summary>
	public FFilePath SourceFile;
	///<summary>The pipeline stack to use when importing (an empty array will use the defaults)</summary>
	public TArray<UInterchangePipelineBase> PipelineStack;
	///<summary>Whether the destination folder should be emptied prior to import</summary>
	public bool bEmptyDestinationFolderPriorToImport;
	///<summary>Whether imported assets should be saved and freshly reloaded after import</summary>
	public bool bSaveThenReloadImportedAssets;
	///<summary>Whether we should use the import into level workflow</summary>
	public bool bImportIntoLevel;
}
