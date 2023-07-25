#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CinePrestreamingRecorderSetting.h")]
public partial class UCinePrestreamingRecorderSetting : UMoviePipelineOutputBase {
// CinePrestreamingRecorderSetting
	public FDirectoryPath PackageDirectory;
	public bool bVirtualTextures;
	public bool bNanite;
	public bool bModifyTargetSequence;
	public bool bDisableAdvanceRenderFeatures;
	public int StartFrame;
	public int EndFrame;
	public FOnCinePrestreamingGenerateData OnGenerateData;
}
