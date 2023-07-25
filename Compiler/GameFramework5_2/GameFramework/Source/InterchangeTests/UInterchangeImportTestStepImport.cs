#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeImportTestStepImport.h")]
public partial class UInterchangeImportTestStepImport : UInterchangeImportTestStepBase {
// InterchangeImportTestStepImport
	public FFilePath SourceFile;
	public TArray<UInterchangePipelineBase> PipelineStack;
	public bool bEmptyDestinationFolderPriorToImport;
	public bool bSaveThenReloadImportedAssets;
	public bool bImportIntoLevel;
}
