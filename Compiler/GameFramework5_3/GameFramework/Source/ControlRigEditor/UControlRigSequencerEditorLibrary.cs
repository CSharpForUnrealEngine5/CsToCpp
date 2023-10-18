namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a set of helper functions to access various parts of the Sequencer and Control Rig API via Python and Blueprints.</summary>
[CppInclude("ControlRigSequencerEditorLibrary.h")]
public partial class UControlRigSequencerEditorLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get all of the visible control rigs in the level</summary>
	public static TArray<UControlRig> GetVisibleControlRigs() { return default; }
	///<summary>Get all of the control rigs and their bindings in the level sequence</summary>
	public static TArray<FControlRigSequencerBindingProxy> GetControlRigs(ULevelSequence LevelSequence) { return default; }
	///<summary>Find or create a Control Rig track of a specific class based upon the binding</summary>
	public static UMovieSceneTrack FindOrCreateControlRigTrack(UWorld World,ULevelSequence LevelSequence,UClass ControlRigClass,FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Find or create a Control Rig Component</summary>
	public static TArray<UMovieSceneTrack> FindOrCreateControlRigComponentTrack(UWorld World,ULevelSequence LevelSequence,FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Load anim sequence into this control rig section</summary>
	public static bool LoadAnimSequenceIntoControlRigSection(UMovieSceneSection MovieSceneSection,UAnimSequence AnimSequence,USkeletalMeshComponent SkelMeshComp,FFrameNumber InStartFrame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bKeyReduce/*=false*/,float Tolerance/*=0.001f*/) { return default; }
	///<summary>Bake the current animation in the binding to a Control Rig track</summary>
	public static bool BakeToControlRig(UWorld World,ULevelSequence LevelSequence,UClass ControlRigClass,UAnimSeqExportOption ExportOptions,bool bReduceKeys,float Tolerance,FMovieSceneBindingProxy Binding) { return default; }
	///<summary>Bake the constraint to keys based on the passed in frames. This will use the open sequencer to bake. See ConstraintsScriptingLibrary to get the list of available constraints</summary>
	public static bool BakeConstraint(UWorld World,UTickableConstraint Constraint,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Bake the constraint to keys based on the passed in settings. This will use the open sequencer to bake. See ConstraintsScriptingLibrary to get the list of available constraints</summary>
	public static bool BakeConstraints(UWorld World,TArray<UTickableConstraint> InConstraints,FBakingAnimationKeySettings InSettings) { return default; }
	///<summary>Add a constraint possibly adding to sequencer also if one is open.</summary>
	public static UTickableConstraint AddConstraint(UWorld World,ETransformConstraintType InType,UTransformableHandle InChild,UTransformableHandle InParent,bool bMaintainOffset) { return default; }
	///<summary>Get the constraint keys for the specified constraint</summary>
	public static bool GetConstraintKeys(UTickableConstraint InConstraint,UMovieSceneSection ConstraintSection,TArray<bool> OutBools,TArray<FFrameNumber> OutFrames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Set the constraint active key in the current open Sequencer</summary>
	public static bool SetConstraintActiveKey(UTickableConstraint InConstraint,bool bActive,FFrameNumber InFrame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get all constraints for this object, which is described by a transformable handle</summary>
	public static TArray<UTickableConstraint> GetConstraintsForHandle(UWorld InWorld,UTransformableHandle InChild) { return default; }
	///<summary>Move the constraint active key in the current open Sequencer</summary>
	public static bool MoveConstraintKey(UTickableConstraint Constraint,UMovieSceneSection ConstraintSection,FFrameNumber InTime,FFrameNumber InNewTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Delete the Key for the Constraint at the specified time.</summary>
	public static bool DeleteConstraintKey(UTickableConstraint Constraint,UMovieSceneSection ConstraintSection,FFrameNumber InTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Compensate constraint at the specfied time</summary>
	public static bool Compensate(UTickableConstraint InConstraint,FFrameNumber InTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Compensate constraint at all keys</summary>
	public static bool CompensateAll(UTickableConstraint InConstraint) { return default; }
	///<summary>Peform a Tween operation on the current active sequencer time(must be visible).</summary>
	public static bool TweenControlRig(ULevelSequence LevelSequence,UControlRig ControlRig,float TweenValue) { return default; }
	///<summary>Peform specified blend operation based upon selected keys in the curve editor or selected control rig controls</summary>
	public static bool BlendValuesOnSelected(ULevelSequence LevelSequence,EAnimToolBlendOperation BlendOperation,float BlendValue) { return default; }
	///<summary>Peform a Snap operation to snap the children to the parent.</summary>
	public static bool SnapControlRig(ULevelSequence LevelSequence,FFrameNumber StartFrame,FFrameNumber EndFrame,FControlRigSnapperSelection ChildrenToSnap,FControlRigSnapperSelection ParentToSnap,UControlRigSnapSettings SnapSettings,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get Actors World Transform at a specific time</summary>
	public static FTransform GetActorWorldTransform(ULevelSequence LevelSequence,AActor Actor,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get Actors World Transforms at specific times</summary>
	public static TArray<FTransform> GetActorWorldTransforms(ULevelSequence LevelSequence,AActor Actor,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get SkeletalMeshComponent World Transform at a specific time</summary>
	public static FTransform GetSkeletalMeshComponentWorldTransform(ULevelSequence LevelSequence,USkeletalMeshComponent SkeletalMeshComponent,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,FName ReferenceName/*=NAME_None*/) { return default; }
	///<summary>Get SkeletalMeshComponents World Transforms at specific times</summary>
	public static TArray<FTransform> GetSkeletalMeshComponentWorldTransforms(ULevelSequence LevelSequence,USkeletalMeshComponent SkeletalMeshComponent,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,FName ReferenceName/*=NAME_None*/) { return default; }
	///<summary>Get ControlRig Control&#39;s World Transform at a specific time</summary>
	public static FTransform GetControlRigWorldTransform(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get ControlRig Control&#39;s World Transforms at specific times</summary>
	public static TArray<FTransform> GetControlRigWorldTransforms(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Set ControlRig Control&#39;s World Transform at a specific time</summary>
	public static void SetControlRigWorldTransform(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,FTransform WorldTransform,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	///<summary>Set ControlRig Control&#39;s World Transforms at a specific times.</summary>
	public static void SetControlRigWorldTransforms(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,TArray<FTransform> WorldTransforms,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Get ControlRig Control&#39;s float value at a specific time</summary>
	public static float GetLocalControlRigFloat(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get ControlRig Control&#39;s float values at specific times</summary>
	public static TArray<float> GetLocalControlRigFloats(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Set ControlRig Control&#39;s float value at specific time</summary>
	public static void SetLocalControlRigFloat(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,float Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	///<summary>Set ControlRig Control&#39;s float values at specific times</summary>
	public static void SetLocalControlRigFloats(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,TArray<float> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Get ControlRig Control&#39;s bool value at a specific time</summary>
	public static bool GetLocalControlRigBool(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get ControlRig Control&#39;s bool values at specific times</summary>
	public static TArray<bool> GetLocalControlRigBools(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Set ControlRig Control&#39;s bool value at specific time</summary>
	public static void SetLocalControlRigBool(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,bool Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	///<summary>Set ControlRig Control&#39;s bool values at specific times</summary>
	public static void SetLocalControlRigBools(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,TArray<bool> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Get ControlRig Control&#39;s integer value at a specific time</summary>
	public static int GetLocalControlRigInt(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get ControlRig Control&#39;s integer values at specific times</summary>
	public static TArray<int> GetLocalControlRigInts(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Set ControlRig Control&#39;s int value at specific time</summary>
	public static void SetLocalControlRigInt(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,int Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	///<summary>Set ControlRig Control&#39;s int values at specific times</summary>
	public static void SetLocalControlRigInts(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,TArray<int> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Get ControlRig Control&#39;s Vector2D value at a specific time</summary>
	public static FVector2D GetLocalControlRigVector2D(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get ControlRig Control&#39;s Vector2D values at specific times</summary>
	public static TArray<FVector2D> GetLocalControlRigVector2Ds(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Set ControlRig Control&#39;s Vector2D value at specific time</summary>
	public static void SetLocalControlRigVector2D(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,FVector2D Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	///<summary>Set ControlRig Control&#39;s Vector2D values at specific times</summary>
	public static void SetLocalControlRigVector2Ds(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,TArray<FVector2D> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Get ControlRig Control&#39;s Position value at a specific time</summary>
	public static FVector GetLocalControlRigPosition(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get ControlRig Control&#39;s Position values at specific times</summary>
	public static TArray<FVector> GetLocalControlRigPositions(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Set ControlRig Control&#39;s Position value at specific time</summary>
	public static void SetLocalControlRigPosition(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,FVector Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	///<summary>Set ControlRig Control&#39;s Position values at specific times</summary>
	public static void SetLocalControlRigPositions(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,TArray<FVector> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Get ControlRig Control&#39;s Rotator value at a specific time</summary>
	public static FRotator GetLocalControlRigRotator(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get ControlRig Control&#39;s Rotator values at specific times</summary>
	public static TArray<FRotator> GetLocalControlRigRotators(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Set ControlRig Control&#39;s Rotator value at specific time</summary>
	public static void SetLocalControlRigRotator(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,FRotator Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	///<summary>Set ControlRig Control&#39;s Rotator values at specific times</summary>
	public static void SetLocalControlRigRotators(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,TArray<FRotator> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Get ControlRig Control&#39;s Scale value at a specific time</summary>
	public static FVector GetLocalControlRigScale(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get ControlRig Control&#39;s Scale values at specific times</summary>
	public static TArray<FVector> GetLocalControlRigScales(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Set ControlRig Control&#39;s Scale value at specific time</summary>
	public static void SetLocalControlRigScale(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,FVector Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	///<summary>Set ControlRig Control&#39;s Scale values at specific times</summary>
	public static void SetLocalControlRigScales(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,TArray<FVector> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Get ControlRig Control&#39;s EulerTransform value at a specific time</summary>
	public static FEulerTransform GetLocalControlRigEulerTransform(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get ControlRig Control&#39;s EulerTransform values at specific times</summary>
	public static TArray<FEulerTransform> GetLocalControlRigEulerTransforms(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Set ControlRig Control&#39;s EulerTransform value at specific time</summary>
	public static void SetLocalControlRigEulerTransform(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,FEulerTransform Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	///<summary>Set ControlRig Control&#39;s EulerTransform values at specific times</summary>
	public static void SetLocalControlRigEulerTransforms(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,TArray<FEulerTransform> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Get ControlRig Control&#39;s TransformNoScale value at a specific time</summary>
	public static FTransformNoScale GetLocalControlRigTransformNoScale(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get ControlRig Control&#39;s TransformNoScale values at specific times</summary>
	public static TArray<FTransformNoScale> GetLocalControlRigTransformNoScales(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Set ControlRig Control&#39;s TransformNoScale value at specific time</summary>
	public static void SetLocalControlRigTransformNoScale(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,FTransformNoScale Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	///<summary>Set ControlRig Control&#39;s TransformNoScale values at specific times</summary>
	public static void SetLocalControlRigTransformNoScales(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,TArray<FTransformNoScale> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>Get ControlRig Control&#39;s Transform value at a specific time</summary>
	public static FTransform GetLocalControlRigTransform(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Get ControlRig Control&#39;s Transform values at specific times</summary>
	public static TArray<FTransform> GetLocalControlRigTransforms(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Set ControlRig Control&#39;s Transform value at specific time</summary>
	public static void SetLocalControlRigTransform(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,FFrameNumber Frame,FTransform Value,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/,bool bSetKey/*=true*/) {}
	///<summary>Set ControlRig Control&#39;s Transform values at specific times</summary>
	public static void SetLocalControlRigTransforms(ULevelSequence LevelSequence,UControlRig ControlRig,FName ControlName,TArray<FFrameNumber> Frames,TArray<FTransform> Values,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	///<summary>* Import FBX onto a control rig with the specified track and section</summary>
	public static bool ImportFBXToControlRigTrack(UWorld World,ULevelSequence InSequence,UMovieSceneControlRigParameterTrack InTrack,UMovieSceneControlRigParameterSection InSection,TArray<string> SelectedControlRigNames,UMovieSceneUserImportFBXControlRigSettings ImportFBXControlRigSettings,string ImportFilename) { return default; }
	///<summary>Exports an FBX from the given control rig section.</summary>
	public static bool ExportFBXFromControlRigSection(ULevelSequence Sequence,UMovieSceneControlRigParameterSection Section,UMovieSceneUserExportFBXControlRigSettings ExportFBXControlRigSettings) { return default; }
	///<summary>* Collapse and bake all sections and layers on a control rig track to just one section.</summary>
	public static bool CollapseControlRigAnimLayers(ULevelSequence InSequence,UMovieSceneControlRigParameterTrack InTrack,bool bKeyReduce/*=false*/,float Tolerance/*=0.001f*/) { return default; }
	///<summary>* Collapse and bake all sections and layers on a control rig track to just one section using passed in settings.</summary>
	public static bool CollapseControlRigAnimLayersWithSettings(ULevelSequence InSequence,UMovieSceneControlRigParameterTrack InTrack,FBakingAnimationKeySettings InSettings) { return default; }
	///<summary>* Get the default parent key, can be used a parent space.</summary>
	public static FRigElementKey GetDefaultParentKey() { return default; }
	///<summary>* Get the default world space key, can be used a world space.</summary>
	public static FRigElementKey GetWorldSpaceReferenceKey() { return default; }
	///<summary>* Set the a key for the Control Rig Space for the Control at the specified time. If space is the same as the current no key witll be set.</summary>
	public static bool SetControlRigSpace(ULevelSequence InSequence,UControlRig InControlRig,FName InControlName,FRigElementKey InSpaceKey,FFrameNumber InTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Bake specified Control Rig Controls to a specified Space based upon the current settings</summary>
	public static bool BakeControlRigSpace(ULevelSequence InSequence,UControlRig InControlRig,TArray<FName> InControlNames,FRigSpacePickerBakeSettings InSettings,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Delete the Control Rig Space Key for the Control at the specified time. This will delete any attached Control Rig keys at this time and will perform any needed compensation to the new space.</summary>
	public static bool DeleteControlRigSpace(ULevelSequence InSequence,UControlRig InControlRig,FName InControlName,FFrameNumber InTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Move the Control Rig Space Key for the Control at the specified time to the new time. This will also move any Control Rig keys at this space switch boundary.</summary>
	public static bool MoveControlRigSpace(ULevelSequence InSequence,UControlRig InControlRig,FName InControlName,FFrameNumber InTime,FFrameNumber InNewTime,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	///<summary>Rename the Control Rig Channels in Sequencer to the specified new control names, which should be present on the Control Rig</summary>
	public static bool RenameControlRigControlChannels(ULevelSequence InSequence,UControlRig InControlRig,TArray<FName> InOldControlNames,TArray<FName> InNewControlNames) { return default; }
	///<summary>Get the controls mask for the given ControlName</summary>
	public static bool GetControlsMask(UMovieSceneSection InSection,FName ControlName) { return default; }
	///<summary>Set the controls mask for the given ControlNames</summary>
	public static void SetControlsMask(UMovieSceneSection InSection,TArray<FName> ControlNames,bool bVisible) {}
	///<summary>Shows all of the controls for the given section</summary>
	public static void ShowAllControls(UMovieSceneSection InSection) {}
	///<summary>Hides all of the controls for the given section</summary>
	public static void HideAllControls(UMovieSceneSection InSection) {}
	///<summary>Whether or not the control rig is an FK Control Rig.</summary>
	public static bool IsFKControlRig(UControlRig InControlRig) { return default; }
	///<summary>Get FKControlRig Apply Mode.</summary>
	public static EControlRigFKRigExecuteMode GetFKControlRigApplyMode(UControlRig InControlRig) { return default; }
	///<summary>Set the FK Control Rig to apply mode</summary>
	public static bool SetControlRigApplyMode(UControlRig InControlRig,EControlRigFKRigExecuteMode InApplyMode) { return default; }
}
