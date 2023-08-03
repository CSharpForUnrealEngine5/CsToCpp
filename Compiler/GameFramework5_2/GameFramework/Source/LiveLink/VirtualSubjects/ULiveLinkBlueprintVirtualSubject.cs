#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for creating virtual subjects in Blueprints</summary>
[CppInclude("VirtualSubjects/LiveLinkBlueprintVirtualSubject.h")]
public partial class ULiveLinkBlueprintVirtualSubject : ULiveLinkVirtualSubject {
	public static UClass StaticClass() {return default;}
	///<summary>OnInitialize</summary>
	public  void OnInitialize() {}
	///<summary>OnUpdate</summary>
	public  void OnUpdate() {}
	///<summary>UpdateVirtualSubjectStaticData_Internal</summary>
	public  bool UpdateVirtualSubjectStaticData_Internal(FLiveLinkBaseStaticData InStruct) { return default; }
	///<summary>UpdateVirtualSubjectFrameData_Internal</summary>
	public  bool UpdateVirtualSubjectFrameData_Internal(FLiveLinkBaseFrameData InStruct,bool bInShouldStampCurrentTime) { return default; }
}
