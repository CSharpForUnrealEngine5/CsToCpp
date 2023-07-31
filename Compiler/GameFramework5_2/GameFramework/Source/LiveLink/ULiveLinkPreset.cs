#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkPreset.h")]
public partial class ULiveLinkPreset : UObject {
	///<summary>Sources</summary>
	public TArray<FLiveLinkSourcePreset> Sources;
	///<summary>Subjects</summary>
	public TArray<FLiveLinkSubjectPreset> Subjects;
	///<summary>ApplyToClient</summary>
	public  bool ApplyToClient() { return default; }
	///<summary>Remove all previous sources and subjects and add the sources and subjects from this preset.</summary>
	public  void ApplyToClientLatent(UObject WorldContextObject,FLatentActionInfo LatentInfo) {}
	///<summary>Add the sources and subjects from this preset, but leave any existing sources and subjects connected.</summary>
	public  bool AddToClient(bool bRecreatePresets/*=true*/) { return default; }
	///<summary>Reset this preset and build the list of sources and subjects from the client.</summary>
	public  void BuildFromClient() {}
}
