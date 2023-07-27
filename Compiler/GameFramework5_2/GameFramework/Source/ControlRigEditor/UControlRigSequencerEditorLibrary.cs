#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigSequencerEditorLibrary.h")]
///<summary>This is a set of helper functions to access various parts of the Sequencer and Control Rig API via Python and Blueprints.</summary>
public partial class UControlRigSequencerEditorLibrary : UBlueprintFunctionLibrary {
// ControlRigSequencerEditorLibrary
	public static TArray<UControlRig> GetVisibleControlRigs() { return default; }
	public static TArray<FControlRigSequencerBindingProxy> GetControlRigs(ULevelSequence LevelSequence) { return default; }
	public static UMovieSceneTrack FindOrCreateControlRigTrack(UWorld World,ULevelSequence LevelSequence,UClass ControlRigClass,FMovieSceneBindingProxy InBinding) { return default; }
	public static TArray<UMovieSceneTrack> FindOrCreateControlRigComponentTrack(UWorld World,ULevelSequence LevelSequence,FMovieSceneBindingProxy InBinding) { return default; }
	public static bool LoadAnimSequenceIntoControlRigSection(UMovieSceneSection MovieSceneSection,UAnimSequence AnimSequence,USkeletalMeshComponent SkelMeshComp,FFrameNumber InStartFrame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bKeyReduce/*=false*/,float Tolerance/*=0.001f*/) { return default; }
	public static bool BakeToControlRig(UWorld World,ULevelSequence LevelSequence,UClass ControlRigClass,UAnimSeqExportOption ExportOptions,bool bReduceKeys,float Tolerance,FMovieSceneBindingProxy Binding) { return default; }
	public static bool BakeConstraint(UWorld World,UTickableConstraint Constraint,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static UTickableConstraint AddConstraint(UWorld World,ETransformConstraintType InType,UTransformableHandle InChild,UTransformableHandle InParent,bool bMaintainOffset) { return default; }
	public static bool GetConstraintKeys(UTickableConstraint InConstraint,UMovieSceneSection ConstraintSection,TArray<bool> OutBools,TArray<FFrameNumber> OutFrames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static bool SetConstraintActiveKey(UTickableConstraint InConstraint,bool bActive,FFrameNumber InFrame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static TArray<UTickableConstraint> GetConstraintsForHandle(UWorld InWorld,UTransformableHandle InChild) { return default; }
	public static bool MoveConstraintKey(UTickableConstraint Constraint,UMovieSceneSection ConstraintSection,FFrameNumber InTime,FFrameNumber InNewTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static bool DeleteConstraintKey(UTickableConstraint Constraint,UMovieSceneSection ConstraintSection,FFrameNumber InTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static bool Compensate(UTickableConstraint InConstraint,FFrameNumber InTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static bool CompensateAll(UTickableConstraint InConstraint) { return default; }
	public static bool TweenControlRig(ULevelSequence LevelSequence,UControlRig ControlRig,float TweenValue) { return default; }
	public static bool BlendValuesOnSelected(ULevelSequence LevelSequence,EAnimToolBlendOperation BlendOperation,float BlendValue) { return default; }
	public static bool SnapControlRig(ULevelSequence LevelSequence,FFrameNumber StartFrame,FFrameNumber EndFrame,FControlRigSnapperSelection ChildrenToSnap,FControlRigSnapperSelection ParentToSnap,UControlRigSnapSettings SnapSettings,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static FTransform GetActorWorldTransform(ULevelSequence LevelSequence,AActor Actor,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static TArray<FTransform> GetActorWorldTransforms(ULevelSequence LevelSequence,AActor Actor,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static FTransform GetSkeletalMeshComponentWorldTransform(ULevelSequence LevelSequence,USkeletalMeshComponent SkeletalMeshComponent,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,string ReferenceName/*=NAME_None*/) { return default; }
	public static TArray<FTransform> GetSkeletalMeshComponentWorldTransforms(ULevelSequence LevelSequence,USkeletalMeshComponent SkeletalMeshComponent,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,string ReferenceName/*=NAME_None*/) { return default; }
	public static FTransform GetControlRigWorldTransform(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static TArray<FTransform> GetControlRigWorldTransforms(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static void SetControlRigWorldTransform(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,FTransform WorldTransform,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public static void SetControlRigWorldTransforms(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FTransform> WorldTransforms,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public static float GetLocalControlRigFloat(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static TArray<float> GetLocalControlRigFloats(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static void SetLocalControlRigFloat(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,float Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public static void SetLocalControlRigFloats(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<float> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public static bool GetLocalControlRigBool(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static TArray<bool> GetLocalControlRigBools(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static void SetLocalControlRigBool(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,bool Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public static void SetLocalControlRigBools(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<bool> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public static int GetLocalControlRigInt(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static TArray<int> GetLocalControlRigInts(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static void SetLocalControlRigInt(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,int Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public static void SetLocalControlRigInts(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<int> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public static FVector2D GetLocalControlRigVector2D(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static TArray<FVector2D> GetLocalControlRigVector2Ds(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static void SetLocalControlRigVector2D(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,FVector2D Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public static void SetLocalControlRigVector2Ds(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FVector2D> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public static FVector GetLocalControlRigPosition(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static TArray<FVector> GetLocalControlRigPositions(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static void SetLocalControlRigPosition(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,FVector Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public static void SetLocalControlRigPositions(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FVector> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public static FRotator GetLocalControlRigRotator(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static TArray<FRotator> GetLocalControlRigRotators(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static void SetLocalControlRigRotator(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,FRotator Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public static void SetLocalControlRigRotators(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FRotator> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public static FVector GetLocalControlRigScale(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static TArray<FVector> GetLocalControlRigScales(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static void SetLocalControlRigScale(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,FVector Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public static void SetLocalControlRigScales(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FVector> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public static FEulerTransform GetLocalControlRigEulerTransform(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static TArray<FEulerTransform> GetLocalControlRigEulerTransforms(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static void SetLocalControlRigEulerTransform(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,FEulerTransform Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public static void SetLocalControlRigEulerTransforms(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FEulerTransform> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public static FTransformNoScale GetLocalControlRigTransformNoScale(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static TArray<FTransformNoScale> GetLocalControlRigTransformNoScales(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static void SetLocalControlRigTransformNoScale(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,FTransformNoScale Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public static void SetLocalControlRigTransformNoScales(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FTransformNoScale> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public static FTransform GetLocalControlRigTransform(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static TArray<FTransform> GetLocalControlRigTransforms(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static void SetLocalControlRigTransform(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,FFrameNumber Frame,FTransform Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public static void SetLocalControlRigTransforms(ULevelSequence LevelSequence,UControlRig ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FTransform> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public static bool ImportFBXToControlRigTrack(UWorld World,ULevelSequence InSequence,UMovieSceneControlRigParameterTrack InTrack,UMovieSceneControlRigParameterSection InSection,TArray<string> SelectedControlRigNames,UMovieSceneUserImportFBXControlRigSettings ImportFBXControlRigSettings,string ImportFilename) { return default; }
	public static bool CollapseControlRigAnimLayers(ULevelSequence InSequence,UMovieSceneControlRigParameterTrack InTrack,bool bKeyReduce/*=false*/,float Tolerance/*=0.001f*/) { return default; }
	public static FRigElementKey GetDefaultParentKey() { return default; }
	public static FRigElementKey GetWorldSpaceReferenceKey() { return default; }
	public static bool SetControlRigSpace(ULevelSequence InSequence,UControlRig InControlRig,string InControlName,FRigElementKey InSpaceKey,FFrameNumber InTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static bool BakeControlRigSpace(ULevelSequence InSequence,UControlRig InControlRig,TArray<string> InControlNames,FRigSpacePickerBakeSettings InSettings,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static bool DeleteControlRigSpace(ULevelSequence InSequence,UControlRig InControlRig,string InControlName,FFrameNumber InTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static bool MoveControlRigSpace(ULevelSequence InSequence,UControlRig InControlRig,string InControlName,FFrameNumber InTime,FFrameNumber InNewTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public static bool RenameControlRigControlChannels(ULevelSequence InSequence,UControlRig InControlRig,TArray<string> InOldControlNames,TArray<string> InNewControlNames) { return default; }
	public static bool GetControlsMask(UMovieSceneSection InSection,string ControlName) { return default; }
	public static void SetControlsMask(UMovieSceneSection InSection,TArray<string> ControlNames,bool bVisible) {}
	public static void ShowAllControls(UMovieSceneSection InSection) {}
	public static void HideAllControls(UMovieSceneSection InSection) {}
	public static bool IsFKControlRig(UControlRig InControlRig) { return default; }
	public static EControlRigFKRigExecuteMode GetFKControlRigApplyMode(UControlRig InControlRig) { return default; }
	public static bool SetControlRigApplyMode(UControlRig InControlRig,EControlRigFKRigExecuteMode InApplyMode) { return default; }
}
