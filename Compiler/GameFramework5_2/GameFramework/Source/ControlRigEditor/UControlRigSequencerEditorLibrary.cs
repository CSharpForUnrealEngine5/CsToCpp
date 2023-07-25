#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigSequencerEditorLibrary.h")]
///<summary>This is a set of helper functions to access various parts of the Sequencer and Control Rig API via Python and Blueprints.</summary>
public partial class UControlRigSequencerEditorLibrary : UBlueprintFunctionLibrary {
// ControlRigSequencerEditorLibrary
	public TArray<UObject> GetVisibleControlRigs() { return default; }
	public TArray<FControlRigSequencerBindingProxy> GetControlRigs(UObject LevelSequence) { return default; }
	public UObject FindOrCreateControlRigTrack(UObject World,UObject LevelSequence,UClass ControlRigClass,FMovieSceneBindingProxy InBinding) { return default; }
	public TArray<UObject> FindOrCreateControlRigComponentTrack(UObject World,UObject LevelSequence,FMovieSceneBindingProxy InBinding) { return default; }
	public bool LoadAnimSequenceIntoControlRigSection(UObject MovieSceneSection,UObject AnimSequence,UObject SkelMeshComp,FFrameNumber InStartFrame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bKeyReduce/*=false*/,float Tolerance/*=0.001f*/) { return default; }
	public bool BakeToControlRig(UObject World,UObject LevelSequence,UClass ControlRigClass,UObject ExportOptions,bool bReduceKeys,float Tolerance,FMovieSceneBindingProxy Binding) { return default; }
	public bool BakeConstraint(UObject World,UObject Constraint,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public UObject AddConstraint(UObject World,ETransformConstraintType InType,UObject InChild,UObject InParent,bool bMaintainOffset) { return default; }
	public bool GetConstraintKeys(UObject InConstraint,UObject ConstraintSection,TArray<bool> OutBools,TArray<FFrameNumber> OutFrames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public bool SetConstraintActiveKey(UObject InConstraint,bool bActive,FFrameNumber InFrame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public TArray<UObject> GetConstraintsForHandle(UObject InWorld,UObject InChild) { return default; }
	public bool MoveConstraintKey(UObject Constraint,UObject ConstraintSection,FFrameNumber InTime,FFrameNumber InNewTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public bool DeleteConstraintKey(UObject Constraint,UObject ConstraintSection,FFrameNumber InTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public bool Compensate(UObject InConstraint,FFrameNumber InTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public bool CompensateAll(UObject InConstraint) { return default; }
	public bool TweenControlRig(UObject LevelSequence,UObject ControlRig,float TweenValue) { return default; }
	public bool BlendValuesOnSelected(UObject LevelSequence,EAnimToolBlendOperation BlendOperation,float BlendValue) { return default; }
	public bool SnapControlRig(UObject LevelSequence,FFrameNumber StartFrame,FFrameNumber EndFrame,FControlRigSnapperSelection ChildrenToSnap,FControlRigSnapperSelection ParentToSnap,UObject SnapSettings,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public FTransform GetActorWorldTransform(UObject LevelSequence,UObject Actor,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public TArray<FTransform> GetActorWorldTransforms(UObject LevelSequence,UObject Actor,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public FTransform GetSkeletalMeshComponentWorldTransform(UObject LevelSequence,UObject SkeletalMeshComponent,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,string ReferenceName/*=NAME_None*/) { return default; }
	public TArray<FTransform> GetSkeletalMeshComponentWorldTransforms(UObject LevelSequence,UObject SkeletalMeshComponent,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,string ReferenceName/*=NAME_None*/) { return default; }
	public FTransform GetControlRigWorldTransform(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public TArray<FTransform> GetControlRigWorldTransforms(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetControlRigWorldTransform(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,FTransform WorldTransform,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public void SetControlRigWorldTransforms(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FTransform> WorldTransforms,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public float GetLocalControlRigFloat(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public TArray<float> GetLocalControlRigFloats(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetLocalControlRigFloat(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,float Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public void SetLocalControlRigFloats(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<float> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public bool GetLocalControlRigBool(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public TArray<bool> GetLocalControlRigBools(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetLocalControlRigBool(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,bool Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public void SetLocalControlRigBools(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<bool> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public int GetLocalControlRigInt(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public TArray<int> GetLocalControlRigInts(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetLocalControlRigInt(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,int Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public void SetLocalControlRigInts(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<int> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public FVector2D GetLocalControlRigVector2D(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public TArray<FVector2D> GetLocalControlRigVector2Ds(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetLocalControlRigVector2D(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,FVector2D Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public void SetLocalControlRigVector2Ds(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FVector2D> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public FVector GetLocalControlRigPosition(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public TArray<FVector> GetLocalControlRigPositions(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetLocalControlRigPosition(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,FVector Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public void SetLocalControlRigPositions(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FVector> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public FRotator GetLocalControlRigRotator(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public TArray<FRotator> GetLocalControlRigRotators(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetLocalControlRigRotator(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,FRotator Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public void SetLocalControlRigRotators(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FRotator> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public FVector GetLocalControlRigScale(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public TArray<FVector> GetLocalControlRigScales(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetLocalControlRigScale(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,FVector Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public void SetLocalControlRigScales(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FVector> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public FEulerTransform GetLocalControlRigEulerTransform(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public TArray<FEulerTransform> GetLocalControlRigEulerTransforms(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetLocalControlRigEulerTransform(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,FEulerTransform Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public void SetLocalControlRigEulerTransforms(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FEulerTransform> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public FTransformNoScale GetLocalControlRigTransformNoScale(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public TArray<FTransformNoScale> GetLocalControlRigTransformNoScales(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetLocalControlRigTransformNoScale(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,FTransformNoScale Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public void SetLocalControlRigTransformNoScales(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FTransformNoScale> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public FTransform GetLocalControlRigTransform(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public TArray<FTransform> GetLocalControlRigTransforms(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetLocalControlRigTransform(UObject LevelSequence,UObject ControlRig,string ControlName,FFrameNumber Frame,FTransform Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	public void SetLocalControlRigTransforms(UObject LevelSequence,UObject ControlRig,string ControlName,TArray<FFrameNumber> Frames,TArray<FTransform> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public bool ImportFBXToControlRigTrack(UObject World,UObject InSequence,UObject InTrack,UObject InSection,TArray<string> SelectedControlRigNames,UObject ImportFBXControlRigSettings,string ImportFilename) { return default; }
	public bool CollapseControlRigAnimLayers(UObject InSequence,UObject InTrack,bool bKeyReduce/*=false*/,float Tolerance/*=0.001f*/) { return default; }
	public FRigElementKey GetDefaultParentKey() { return default; }
	public FRigElementKey GetWorldSpaceReferenceKey() { return default; }
	public bool SetControlRigSpace(UObject InSequence,UObject InControlRig,string InControlName,FRigElementKey InSpaceKey,FFrameNumber InTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public bool BakeControlRigSpace(UObject InSequence,UObject InControlRig,TArray<string> InControlNames,FRigSpacePickerBakeSettings InSettings,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public bool DeleteControlRigSpace(UObject InSequence,UObject InControlRig,string InControlName,FFrameNumber InTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public bool MoveControlRigSpace(UObject InSequence,UObject InControlRig,string InControlName,FFrameNumber InTime,FFrameNumber InNewTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public bool RenameControlRigControlChannels(UObject InSequence,UObject InControlRig,TArray<string> InOldControlNames,TArray<string> InNewControlNames) { return default; }
	public bool GetControlsMask(UObject InSection,string ControlName) { return default; }
	public void SetControlsMask(UObject InSection,TArray<string> ControlNames,bool bVisible) {}
	public void ShowAllControls(UObject InSection) {}
	public void HideAllControls(UObject InSection) {}
	public bool IsFKControlRig(UObject InControlRig) { return default; }
	public EControlRigFKRigExecuteMode GetFKControlRigApplyMode(UObject InControlRig) { return default; }
	public bool SetControlRigApplyMode(UObject InControlRig,EControlRigFKRigExecuteMode InApplyMode) { return default; }
}
