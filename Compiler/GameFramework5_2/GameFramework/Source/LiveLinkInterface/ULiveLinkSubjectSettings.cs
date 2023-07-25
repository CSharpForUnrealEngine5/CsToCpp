#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkSubjectSettings.h")]
///<summary>Base class for live link subject settings</summary>
public partial class ULiveLinkSubjectSettings : UObject {
// LiveLinkSubjectSettings
	public TArray<ULiveLinkFramePreProcessor> PreProcessors;
	public ULiveLinkFrameInterpolationProcessor InterpolationProcessor;
	public TArray<ULiveLinkFrameTranslator> Translators;
	public UClass Role;
	public FFrameRate FrameRate;
	public bool bRebroadcastSubject;
}
