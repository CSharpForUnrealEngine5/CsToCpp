namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that hosts an animation ControlRig, manages control components and marshals data between the two</summary>
[CppInclude("ControlRigComponent.h")]
public partial class UControlRigComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The class of control rig to instantiate</summary>
	public UClass ControlRigClass;
	///<summary>Event fired just before this component&#39;s ControlRig is initialized</summary>
	public FControlRigComponentDelegate OnPreInitializeDelegate;
	///<summary>Event fired after this component&#39;s ControlRig is initialized</summary>
	public FControlRigComponentDelegate OnPostInitializeDelegate;
	///<summary>Event fired before this component&#39;s ControlRig is setup</summary>
	public FControlRigComponentDelegate OnPreConstructionDelegate;
	///<summary>Event fired after this component&#39;s ControlRig is setup</summary>
	public FControlRigComponentDelegate OnPostConstructionDelegate;
	///<summary>Event fired before this component&#39;s ControlRig&#39;s forwards solve</summary>
	public FControlRigComponentDelegate OnPreForwardsSolveDelegate;
	///<summary>Event fired after this component&#39;s ControlRig&#39;s forwards solve</summary>
	public FControlRigComponentDelegate OnPostForwardsSolveDelegate;
	///<summary>Get the ControlRig hosted by this component</summary>
	public UControlRig GetControlRig() { return default; }
	///<summary>Returns true if the Component can execute its Control Rig</summary>
	public bool CanExecute() { return default; }
	///<summary>Get the ControlRig&#39;s local time in seconds since its last initialize</summary>
	public float GetAbsoluteTime() { return default; }
	///<summary>OnPreInitialize</summary>
	public void OnPreInitialize(UControlRigComponent Component) {}
	///<summary>OnPostInitialize</summary>
	public void OnPostInitialize(UControlRigComponent Component) {}
	///<summary>OnPreConstruction</summary>
	public void OnPreConstruction(UControlRigComponent Component) {}
	///<summary>OnPostConstruction</summary>
	public void OnPostConstruction(UControlRigComponent Component) {}
	///<summary>OnPreForwardsSolve</summary>
	public void OnPreForwardsSolve(UControlRigComponent Component) {}
	///<summary>OnPostForwardsSolve</summary>
	public void OnPostForwardsSolve(UControlRigComponent Component) {}
	///<summary>Initializes the rig&#39;s memory and calls the construction event</summary>
	public void Initialize() {}
	///<summary>Updates and ticks the rig.</summary>
	public void Update(float DeltaTime/*=0.0f*/) {}
	///<summary>UserDefinedElements</summary>
	public TArray<FControlRigComponentMappedElement> UserDefinedElements;
	///<summary>MappedElements</summary>
	public TArray<FControlRigComponentMappedElement> MappedElements;
	///<summary>Removes all mapped elements from the component</summary>
	public void ClearMappedElements() {}
	///<summary>Replaces the mapped elements on the component with the provided array, should not be used before OnPreInitialize Event</summary>
	public void SetMappedElements(TArray<FControlRigComponentMappedElement> NewMappedElements) {}
	///<summary>Adds the provided mapped elements to the component, should not be used before OnPreInitialize Event</summary>
	public void AddMappedElements(TArray<FControlRigComponentMappedElement> NewMappedElements) {}
	///<summary>Adds a series of mapped bones to the rig, should not be used before OnPreInitialize Event</summary>
	public void AddMappedComponents(TArray<FControlRigComponentMappedComponent> Components) {}
	///<summary>Adds a series of mapped bones to the rig, should not be used before OnPreInitialize Event</summary>
	public void AddMappedSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent,TArray<FControlRigComponentMappedBone> Bones,TArray<FControlRigComponentMappedCurve> Curves) {}
	///<summary>Adds all matching bones to the rig, should not be used before OnPreInitialize Event</summary>
	public void AddMappedCompleteSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent) {}
	///<summary>Setup the initial transforms / ref pose of the bones based on a skeletal mesh</summary>
	public void SetBoneInitialTransformsFromSkeletalMesh(USkeletalMesh InSkeletalMesh) {}
	///<summary>When checked the rig will only run if any of the mapped inputs has changed</summary>
	public bool bEnableLazyEvaluation;
	///<summary>The delta threshold for a translation / position difference. 0.0 disables position differences.</summary>
	public float LazyEvaluationPositionThreshold;
	///<summary>The delta threshold for a rotation difference (in degrees). 0.0 disables rotation differences.</summary>
	public float LazyEvaluationRotationThreshold;
	///<summary>The delta threshold for a scale difference. 0.0 disables scale differences.</summary>
	public float LazyEvaluationScaleThreshold;
	///<summary>When checked the transforms are reset before a tick / update of the rig</summary>
	public bool bResetTransformBeforeTick;
	///<summary>When checked the initial transforms on bones, nulls and controls are reset prior to a construction event</summary>
	public bool bResetInitialsBeforeConstruction;
	///<summary>When checked this ensures to run the rig&#39;s update on the component&#39;s tick automatically</summary>
	public bool bUpdateRigOnTick;
	///<summary>When checked the rig is run in the editor viewport without running / simulation the game</summary>
	public bool bUpdateInEditor;
	///<summary>When checked the rig&#39;s bones are drawn using debug drawing similar to the animation editor viewport</summary>
	public bool bDrawBones;
	///<summary>When checked the rig&#39;s debug drawing instructions are drawn in the viewport</summary>
	public bool bShowDebugDrawing;
	///<summary>Returns all of the names for a given element type (Bone, Control, etc)</summary>
	public TArray<FName> GetElementNames(ERigElementType ElementType/*=ERigElementType.Bone*/) { return default; }
	///<summary>Returns true if an element given a type and name exists in the rig</summary>
	public bool DoesElementExist(FName Name,ERigElementType ElementType/*=ERigElementType.Bone*/) { return default; }
	///<summary>Returns the transform of the bone in the requested space</summary>
	public FTransform GetBoneTransform(FName BoneName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) { return default; }
	///<summary>Returns the initial transform of the bone in the requested space</summary>
	public FTransform GetInitialBoneTransform(FName BoneName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) { return default; }
	///<summary>Sets the transform of the bone in the requested space</summary>
	public void SetBoneTransform(FName BoneName,FTransform Transform,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/,float Weight/*=1.0f*/,bool bPropagateToChildren/*=true*/) {}
	///<summary>Sets the initial transform of the bone in the requested space</summary>
	public void SetInitialBoneTransform(FName BoneName,FTransform InitialTransform,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/,bool bPropagateToChildren/*=false*/) {}
	///<summary>Returns the value of a bool control</summary>
	public bool GetControlBool(FName ControlName) { return default; }
	///<summary>Returns the value of a float control</summary>
	public float GetControlFloat(FName ControlName) { return default; }
	///<summary>Returns the value of an integer control</summary>
	public int GetControlInt(FName ControlName) { return default; }
	///<summary>Returns the value of a Vector3D control</summary>
	public FVector2D GetControlVector2D(FName ControlName) { return default; }
	///<summary>Returns the value of a position control</summary>
	public FVector GetControlPosition(FName ControlName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.LocalSpace*/) { return default; }
	///<summary>Returns the value of a rotator control</summary>
	public FRotator GetControlRotator(FName ControlName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.LocalSpace*/) { return default; }
	///<summary>Returns the value of a scale control</summary>
	public FVector GetControlScale(FName ControlName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.LocalSpace*/) { return default; }
	///<summary>Returns the value of a transform control</summary>
	public FTransform GetControlTransform(FName ControlName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) { return default; }
	///<summary>Sets the value of a bool control</summary>
	public void SetControlBool(FName ControlName,bool Value) {}
	///<summary>Sets the value of a float control</summary>
	public void SetControlFloat(FName ControlName,float Value) {}
	///<summary>Sets the value of an integer control</summary>
	public void SetControlInt(FName ControlName,int Value) {}
	///<summary>Sets the value of a vector2D control</summary>
	public void SetControlVector2D(FName ControlName,FVector2D Value) {}
	///<summary>Sets the value of a position control</summary>
	public void SetControlPosition(FName ControlName,FVector Value,EControlRigComponentSpace Space/*=EControlRigComponentSpace.LocalSpace*/) {}
	///<summary>Sets the value of a rotator control</summary>
	public void SetControlRotator(FName ControlName,FRotator Value,EControlRigComponentSpace Space/*=EControlRigComponentSpace.LocalSpace*/) {}
	///<summary>Sets the value of a scale control</summary>
	public void SetControlScale(FName ControlName,FVector Value,EControlRigComponentSpace Space/*=EControlRigComponentSpace.LocalSpace*/) {}
	///<summary>Sets the value of a transform control</summary>
	public void SetControlTransform(FName ControlName,FTransform Value,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) {}
	///<summary>Returns the offset transform of a control</summary>
	public FTransform GetControlOffset(FName ControlName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) { return default; }
	///<summary>Sets the offset transform of a control</summary>
	public void SetControlOffset(FName ControlName,FTransform OffsetTransform,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) {}
	///<summary>Returns the transform of the space in the requested space</summary>
	public FTransform GetSpaceTransform(FName SpaceName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) { return default; }
	///<summary>Returns the initial transform of the space in the requested space</summary>
	public FTransform GetInitialSpaceTransform(FName SpaceName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) { return default; }
	///<summary>Sets the transform of the space in the requested space</summary>
	public void SetInitialSpaceTransform(FName SpaceName,FTransform InitialTransform,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) {}
	///<summary>SetControlRigClass</summary>
	public void SetControlRigClass(UClass InControlRigClass) {}
	///<summary>SetObjectBinding</summary>
	public void SetObjectBinding(UObject InObjectToBind) {}
	///<summary>ControlRig</summary>
	public UControlRig ControlRig;
}
