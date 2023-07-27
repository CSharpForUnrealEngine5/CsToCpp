#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkBlueprintLibrary.h")]
public partial class ULiveLinkBlueprintLibrary : UBlueprintFunctionLibrary {
// LiveLinkBlueprintLibrary
	public static bool GetPropertyValue(FLiveLinkBasicBlueprintData BasicData,string PropertyName,float Value) { return default; }
	public static void GetCurves(FSubjectFrameHandle SubjectFrameHandle,TMap<string,float> Curves) {}
	public static int NumberOfTransforms(FSubjectFrameHandle SubjectFrameHandle) { return default; }
	public static void TransformNames(FSubjectFrameHandle SubjectFrameHandle,TArray<string> TransformNames) {}
	public static void GetRootTransform(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkTransform LiveLinkTransform) {}
	public static void GetTransformByIndex(FSubjectFrameHandle SubjectFrameHandle,int TransformIndex,FLiveLinkTransform LiveLinkTransform) {}
	public static void GetTransformByName(FSubjectFrameHandle SubjectFrameHandle,string TransformName,FLiveLinkTransform LiveLinkTransform) {}
	public static void GetMetadata(FSubjectFrameHandle SubjectFrameHandle,FSubjectMetadata Metadata) {}
	public static void GetBasicData(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkBasicBlueprintData BasicBlueprintData) {}
	public static bool GetAnimationStaticData(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkSkeletonStaticData AnimationStaticData) { return default; }
	public static bool GetAnimationFrameData(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkAnimationFrameData AnimationFrameData) { return default; }
	public static void TransformName(FLiveLinkTransform LiveLinkTransform,string Name) {}
	public static void ParentBoneSpaceTransform(FLiveLinkTransform LiveLinkTransform,FTransform Transform) {}
	public static void ComponentSpaceTransform(FLiveLinkTransform LiveLinkTransform,FTransform Transform) {}
	public static bool HasParent(FLiveLinkTransform LiveLinkTransform) { return default; }
	public static void GetParent(FLiveLinkTransform LiveLinkTransform,FLiveLinkTransform Parent) {}
	public static int ChildCount(FLiveLinkTransform LiveLinkTransform) { return default; }
	public static void GetChildren(FLiveLinkTransform LiveLinkTransform,TArray<FLiveLinkTransform> Children) {}
	public static bool IsSourceStillValid(FLiveLinkSourceHandle SourceHandle) { return default; }
	public static bool RemoveSource(FLiveLinkSourceHandle SourceHandle) { return default; }
	public static string GetSourceStatus(FLiveLinkSourceHandle SourceHandle) { return default; }
	public static string GetSourceType(FLiveLinkSourceHandle SourceHandle) { return default; }
	public static string GetSourceMachineName(FLiveLinkSourceHandle SourceHandle) { return default; }
	public static string GetSourceTypeFromGuid(FGuid SourceGuid) { return default; }
	public static TArray<FLiveLinkSubjectName> GetLiveLinkEnabledSubjectNames(bool bIncludeVirtualSubject) { return default; }
	public static TArray<FLiveLinkSubjectKey> GetLiveLinkSubjects(bool bIncludeDisabledSubject,bool bIncludeVirtualSubject) { return default; }
	public static bool IsSpecificLiveLinkSubjectEnabled(FLiveLinkSubjectKey SubjectKey,bool bForThisFrame) { return default; }
	public static bool IsLiveLinkSubjectEnabled(FLiveLinkSubjectName SubjectName) { return default; }
	public static void SetLiveLinkSubjectEnabled(FLiveLinkSubjectKey SubjectKey,bool bEnabled) {}
	public static UClass GetSpecificLiveLinkSubjectRole(FLiveLinkSubjectKey SubjectKey) { return default; }
	public static UClass GetLiveLinkSubjectRole(FLiveLinkSubjectName SubjectName) { return default; }
	public static bool EvaluateLiveLinkFrame(FLiveLinkSubjectRepresentation SubjectRepresentation,FLiveLinkBaseBlueprintData OutBlueprintData) { return default; }
	public static bool EvaluateLiveLinkFrameWithSpecificRole(FLiveLinkSubjectName SubjectName,UClass Role,FLiveLinkBaseBlueprintData OutBlueprintData) { return default; }
	public static bool EvaluateLiveLinkFrameAtWorldTimeOffset(FLiveLinkSubjectName SubjectName,UClass Role,float WorldTimeOffset,FLiveLinkBaseBlueprintData OutBlueprintData) { return default; }
	public static bool EvaluateLiveLinkFrameAtSceneTime(FLiveLinkSubjectName SubjectName,UClass Role,FTimecode SceneTime,FLiveLinkBaseBlueprintData OutBlueprintData) { return default; }
}
