#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CinePrestreamingEditorSubsystem.h")]
public partial class UCinePrestreamingEditorSubsystem : UEditorSubsystem {
// CinePrestreamingEditorSubsystem
	public bool IsRendering() { return default; }
	public void GeneratePrestreamingAsset(FCinePrestreamingGenerateAssetArgs InArgs) {}
	public void CreatePackagesFromGeneratedData(TArray<FMoviePipelineCinePrestreamingGeneratedData> InOutData) {}
	public FOnCinePrestreamingGenerateAsset OnAssetGenerated;
	public void OnBuildPrestreamingComplete(UObject InPipelineExecutor,bool bSuccess) {}
	public UMoviePipelineExecutorBase ActiveExecutor;
}
