#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CinePrestreamingEditorSubsystem.h")]
public partial class UCinePrestreamingEditorSubsystem : UEditorSubsystem {
	///<summary>IsRendering</summary>
	public  bool IsRendering() { return default; }
	///<summary>GeneratePrestreamingAsset</summary>
	public  void GeneratePrestreamingAsset(FCinePrestreamingGenerateAssetArgs InArgs) {}
	///<summary>CreatePackagesFromGeneratedData</summary>
	public  void CreatePackagesFromGeneratedData(TArray<FMoviePipelineCinePrestreamingGeneratedData> InOutData) {}
	///<summary>OnAssetGenerated</summary>
	public FOnCinePrestreamingGenerateAsset OnAssetGenerated;
	///<summary>OnBuildPrestreamingComplete</summary>
	public  void OnBuildPrestreamingComplete(UMoviePipelineExecutorBase InPipelineExecutor,bool bSuccess) {}
	///<summary>UPROPERTY(Transient)</summary>
	public UMoviePipelineExecutorBase ActiveExecutor;
}
