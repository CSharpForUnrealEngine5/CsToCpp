namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkBlueprintLibrary.h")]
public partial class ULiveLinkBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the value of a property stored in the Subject Frame</summary>
	public static bool GetPropertyValue(FLiveLinkBasicBlueprintData BasicData,string PropertyName,float Value) { return default; }
	///<summary>Returns the float curves stored in the Subject Frame as a map</summary>
	public static void GetCurves(FSubjectFrameHandle SubjectFrameHandle,TMap<string,float> Curves) {}
	///<summary>Returns the number of Transforms stored in the Subject Frame</summary>
	public static int NumberOfTransforms(FSubjectFrameHandle SubjectFrameHandle) { return default; }
	///<summary>Returns an array of Transform Names stored in the Subject Frame</summary>
	public static void TransformNames(FSubjectFrameHandle SubjectFrameHandle,TArray<string> TransformNames) {}
	///<summary>Returns the Root Transform for the Subject Frame as a LiveLink Transform or the Identity if there are no transforms.</summary>
	public static void GetRootTransform(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkTransform LiveLinkTransform) {}
	///<summary>Returns the LiveLink Transform stored in a Subject Frame at a given index. Returns an Identity transform if Transform Index is invalid.</summary>
	public static void GetTransformByIndex(FSubjectFrameHandle SubjectFrameHandle,int TransformIndex,FLiveLinkTransform LiveLinkTransform) {}
	///<summary>Returns the LiveLink Transform stored in a Subject Frame with a given name. Returns an Identity transform if Transform Name is invalid.</summary>
	public static void GetTransformByName(FSubjectFrameHandle SubjectFrameHandle,string TransformName,FLiveLinkTransform LiveLinkTransform) {}
	///<summary>Returns the Subject Metadata structure stored in the Subject Frame</summary>
	public static void GetMetadata(FSubjectFrameHandle SubjectFrameHandle,FSubjectMetadata Metadata) {}
	///<summary>Returns the Subject base structure stored in the Subject Frame</summary>
	public static void GetBasicData(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkBasicBlueprintData BasicBlueprintData) {}
	///<summary>Returns the Subject&#39;s static data stored in the Subject Frame. Returns false if no valid data found.</summary>
	public static bool GetAnimationStaticData(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkSkeletonStaticData AnimationStaticData) { return default; }
	///<summary>Returns the Subject&#39;s frame data stored in the Subject Frame. Returns false if no valid data found.</summary>
	public static bool GetAnimationFrameData(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkAnimationFrameData AnimationFrameData) { return default; }
	///<summary>Returns the Name of a given LiveLink Transform</summary>
	public static void TransformName(FLiveLinkTransform LiveLinkTransform,string Name) {}
	///<summary>Returns the Transform value in Parent Space for a given LiveLink Transform</summary>
	public static void ParentBoneSpaceTransform(FLiveLinkTransform LiveLinkTransform,FTransform Transform) {}
	///<summary>Returns the Transform value in Root Space for a given LiveLink Transform</summary>
	public static void ComponentSpaceTransform(FLiveLinkTransform LiveLinkTransform,FTransform Transform) {}
	///<summary>Returns whether a given LiveLink Transform has a parent transform</summary>
	public static bool HasParent(FLiveLinkTransform LiveLinkTransform) { return default; }
	///<summary>Returns the Parent LiveLink Transform if one exists or an Identity transform if no parent exists</summary>
	public static void GetParent(FLiveLinkTransform LiveLinkTransform,FLiveLinkTransform Parent) {}
	///<summary>Returns the number of Children for a given LiveLink Transform</summary>
	public static int ChildCount(FLiveLinkTransform LiveLinkTransform) { return default; }
	///<summary>Returns an array of Child LiveLink Transforms for a given LiveLink Transform</summary>
	public static void GetChildren(FLiveLinkTransform LiveLinkTransform,TArray<FLiveLinkTransform> Children) {}
	///<summary>Checks whether the LiveLink Source is valid via its handle</summary>
	public static bool IsSourceStillValid(FLiveLinkSourceHandle SourceHandle) { return default; }
	///<summary>Requests the given LiveLink Source to shut down via its handle</summary>
	public static bool RemoveSource(FLiveLinkSourceHandle SourceHandle) { return default; }
	///<summary>Get the text status of a LiveLink Source via its handle</summary>
	public static FText GetSourceStatus(FLiveLinkSourceHandle SourceHandle) { return default; }
	///<summary>Get the type of a LiveLink Source via its handle</summary>
	public static FText GetSourceType(FLiveLinkSourceHandle SourceHandle) { return default; }
	///<summary>Get the machine name of a LiveLink Source via its handle</summary>
	public static FText GetSourceMachineName(FLiveLinkSourceHandle SourceHandle) { return default; }
	///<summary>Get the type of a source from the given GUID</summary>
	public static FText GetSourceTypeFromGuid(FGuid SourceGuid) { return default; }
	///<summary>Get a list of all enabled subject names</summary>
	public static TArray<FLiveLinkSubjectName> GetLiveLinkEnabledSubjectNames(bool bIncludeVirtualSubject) { return default; }
	///<summary>Get a list of all subjects</summary>
	public static TArray<FLiveLinkSubjectKey> GetLiveLinkSubjects(bool bIncludeDisabledSubject,bool bIncludeVirtualSubject) { return default; }
	///<summary>Whether or not a subject from the specific source is the enabled subject.</summary>
	public static bool IsSpecificLiveLinkSubjectEnabled(FLiveLinkSubjectKey SubjectKey,bool bForThisFrame) { return default; }
	///<summary>Whether or not the client has a subject with this name enabled</summary>
	public static bool IsLiveLinkSubjectEnabled(FLiveLinkSubjectName SubjectName) { return default; }
	///<summary>Set the subject&#39;s from a specific source to enabled, disabling the other in the process.</summary>
	public static void SetLiveLinkSubjectEnabled(FLiveLinkSubjectKey SubjectKey,bool bEnabled) {}
	///<summary>Get the role of a subject from a specific source</summary>
	public static UClass GetSpecificLiveLinkSubjectRole(FLiveLinkSubjectKey SubjectKey) { return default; }
	///<summary>Get the role of the subject with this name</summary>
	public static UClass GetLiveLinkSubjectRole(FLiveLinkSubjectName SubjectName) { return default; }
	///<summary>EvaluateLiveLinkFrame</summary>
	public static bool EvaluateLiveLinkFrame(FLiveLinkSubjectRepresentation SubjectRepresentation,FLiveLinkBaseBlueprintData OutBlueprintData) { return default; }
	///<summary>Fetches a frame on a subject for a specific role. Output is evaluated based on the role</summary>
	public static bool EvaluateLiveLinkFrameWithSpecificRole(FLiveLinkSubjectName SubjectName,UClass Role,FLiveLinkBaseBlueprintData OutBlueprintData) { return default; }
	///<summary>Fetches a frame on a subject for a specific role at an offset from the application current time. Output is evaluated based on the role</summary>
	public static bool EvaluateLiveLinkFrameAtWorldTimeOffset(FLiveLinkSubjectName SubjectName,UClass Role,float WorldTimeOffset,FLiveLinkBaseBlueprintData OutBlueprintData) { return default; }
	///<summary>Fetches a frame on a subject for a specific role at a specified scene time (timecode).</summary>
	public static bool EvaluateLiveLinkFrameAtSceneTime(FLiveLinkSubjectName SubjectName,UClass Role,FTimecode SceneTime,FLiveLinkBaseBlueprintData OutBlueprintData) { return default; }
}
