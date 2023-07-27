#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualSubjects/LiveLinkBlueprintVirtualSubject.h")]
///<summary>Base class for creating virtual subjects in Blueprints</summary>
public partial class ULiveLinkBlueprintVirtualSubject : ULiveLinkVirtualSubject {
// LiveLinkBlueprintVirtualSubject
	public  void OnInitialize() {}
	public  void OnUpdate() {}
	public  bool UpdateVirtualSubjectStaticData_Internal(FLiveLinkBaseStaticData InStruct) { return default; }
	public  bool UpdateVirtualSubjectFrameData_Internal(FLiveLinkBaseFrameData InStruct,bool bInShouldStampCurrentTime) { return default; }
}
