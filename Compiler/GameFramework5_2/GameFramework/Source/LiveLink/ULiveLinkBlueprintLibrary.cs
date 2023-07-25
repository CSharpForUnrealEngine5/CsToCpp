#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkBlueprintLibrary.h")]
public partial class ULiveLinkBlueprintLibrary : UBlueprintFunctionLibrary {
// LiveLinkBlueprintLibrary
	public bool GetPropertyValue(FLiveLinkBasicBlueprintData BasicData,string PropertyName,float Value) { return default; }
	public void GetCurves(FSubjectFrameHandle SubjectFrameHandle,TMap<string,float> Curves) {}
	public int NumberOfTransforms(FSubjectFrameHandle SubjectFrameHandle) { return default; }
	public void TransformNames(FSubjectFrameHandle SubjectFrameHandle,TArray<string> TransformNames) {}
	public void GetRootTransform(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkTransform LiveLinkTransform) {}
	public void GetTransformByIndex(FSubjectFrameHandle SubjectFrameHandle,int TransformIndex,FLiveLinkTransform LiveLinkTransform) {}
	public void GetTransformByName(FSubjectFrameHandle SubjectFrameHandle,string TransformName,FLiveLinkTransform LiveLinkTransform) {}
	public void GetMetadata(FSubjectFrameHandle SubjectFrameHandle,FSubjectMetadata Metadata) {}
	public void GetBasicData(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkBasicBlueprintData BasicBlueprintData) {}
	public bool GetAnimationStaticData(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkSkeletonStaticData AnimationStaticData) { return default; }
	public bool GetAnimationFrameData(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkAnimationFrameData AnimationFrameData) { return default; }
	public void TransformName(FLiveLinkTransform LiveLinkTransform,string Name) {}
	public void ParentBoneSpaceTransform(FLiveLinkTransform LiveLinkTransform,FTransform Transform) {}
	public void ComponentSpaceTransform(FLiveLinkTransform LiveLinkTransform,FTransform Transform) {}
	public bool HasParent(FLiveLinkTransform LiveLinkTransform) { return default; }
	public void GetParent(FLiveLinkTransform LiveLinkTransform,FLiveLinkTransform Parent) {}
	public int ChildCount(FLiveLinkTransform LiveLinkTransform) { return default; }
	public void GetChildren(FLiveLinkTransform LiveLinkTransform,TArray<FLiveLinkTransform> Children) {}
	public bool IsSourceStillValid(FLiveLinkSourceHandle SourceHandle) { return default; }
	public bool RemoveSource(FLiveLinkSourceHandle SourceHandle) { return default; }
	public string GetSourceStatus(FLiveLinkSourceHandle SourceHandle) { return default; }
	public string GetSourceType(FLiveLinkSourceHandle SourceHandle) { return default; }
	public string GetSourceMachineName(FLiveLinkSourceHandle SourceHandle) { return default; }
	public string GetSourceTypeFromGuid(FGuid SourceGuid) { return default; }
	public TArray<FLiveLinkSubjectName> GetLiveLinkEnabledSubjectNames(bool bIncludeVirtualSubject) { return default; }
	public TArray<FLiveLinkSubjectKey> GetLiveLinkSubjects(bool bIncludeDisabledSubject,bool bIncludeVirtualSubject) { return default; }
	public bool IsSpecificLiveLinkSubjectEnabled(FLiveLinkSubjectKey SubjectKey,bool bForThisFrame) { return default; }
	public bool IsLiveLinkSubjectEnabled(FLiveLinkSubjectName SubjectName) { return default; }
	public void SetLiveLinkSubjectEnabled(FLiveLinkSubjectKey SubjectKey,bool bEnabled) {}
	public UClass GetSpecificLiveLinkSubjectRole(FLiveLinkSubjectKey SubjectKey) { return default; }
	public UClass GetLiveLinkSubjectRole(FLiveLinkSubjectName SubjectName) { return default; }
	public bool EvaluateLiveLinkFrame(FLiveLinkSubjectRepresentation SubjectRepresentation,FLiveLinkBaseBlueprintData OutBlueprintData) { return default; }
	public bool EvaluateLiveLinkFrameWithSpecificRole(FLiveLinkSubjectName SubjectName,UClass Role,FLiveLinkBaseBlueprintData OutBlueprintData) { return default; }
	public bool EvaluateLiveLinkFrameAtWorldTimeOffset(FLiveLinkSubjectName SubjectName,UClass Role,float WorldTimeOffset,FLiveLinkBaseBlueprintData OutBlueprintData) { return default; }
	public bool EvaluateLiveLinkFrameAtSceneTime(FLiveLinkSubjectName SubjectName,UClass Role,FTimecode SceneTime,FLiveLinkBaseBlueprintData OutBlueprintData) { return default; }
}
