#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkPreset.h")]
public partial class ULiveLinkPreset : UObject {
// LiveLinkPreset
	public TArray<FLiveLinkSourcePreset> Sources;
	public TArray<FLiveLinkSubjectPreset> Subjects;
	public  bool ApplyToClient() { return default; }
	public  void ApplyToClientLatent(UObject WorldContextObject,FLatentActionInfo LatentInfo) {}
	public  bool AddToClient(bool bRecreatePresets/*=true*/) { return default; }
	public  void BuildFromClient() {}
}
