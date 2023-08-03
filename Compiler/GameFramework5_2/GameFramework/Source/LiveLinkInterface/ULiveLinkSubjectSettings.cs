#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for live link subject settings</summary>
[CppInclude("LiveLinkSubjectSettings.h")]
public partial class ULiveLinkSubjectSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>List of available preprocessor the subject will use.</summary>
	public TArray<ULiveLinkFramePreProcessor> PreProcessors;
	///<summary>The interpolation processor the subject will use.</summary>
	public ULiveLinkFrameInterpolationProcessor InterpolationProcessor;
	///<summary>List of available translator the subject can use.</summary>
	public TArray<ULiveLinkFrameTranslator> Translators;
	///<summary>Role</summary>
	public UClass Role;
	///<summary>Last FrameRate estimated by the subject. If in Timecode mode, this will come directly from the QualifiedFrameTime.</summary>
	public FFrameRate FrameRate;
	///<summary>If enabled, rebroadcast this subject</summary>
	public bool bRebroadcastSubject;
}
