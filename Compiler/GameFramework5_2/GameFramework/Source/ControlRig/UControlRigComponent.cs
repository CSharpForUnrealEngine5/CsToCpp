#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigComponent.h")]
///<summary>A component that hosts an animation ControlRig, manages control components and marshals data between the two</summary>
public partial class UControlRigComponent : UPrimitiveComponent {
// ControlRigComponent
	public UClass ControlRigClass;
	public FControlRigComponentDelegate OnPreInitializeDelegate;
	public FControlRigComponentDelegate OnPostInitializeDelegate;
	public FControlRigComponentDelegate OnPreConstructionDelegate;
	public FControlRigComponentDelegate OnPostConstructionDelegate;
	public FControlRigComponentDelegate OnPreForwardsSolveDelegate;
	public FControlRigComponentDelegate OnPostForwardsSolveDelegate;
	public  UControlRig GetControlRig() { return default; }
	public  bool CanExecute() { return default; }
	public  float GetAbsoluteTime() { return default; }
	public  void OnPreInitialize(UControlRigComponent Component) {}
	public  void OnPostInitialize(UControlRigComponent Component) {}
	public  void OnPreConstruction(UControlRigComponent Component) {}
	public  void OnPostConstruction(UControlRigComponent Component) {}
	public  void OnPreForwardsSolve(UControlRigComponent Component) {}
	public  void OnPostForwardsSolve(UControlRigComponent Component) {}
	public  void Initialize() {}
	public  void Update(float DeltaTime/*=0.0f*/) {}
	public TArray<FControlRigComponentMappedElement> UserDefinedElements;
	public TArray<FControlRigComponentMappedElement> MappedElements;
	public  void ClearMappedElements() {}
	public  void SetMappedElements(TArray<FControlRigComponentMappedElement> NewMappedElements) {}
	public  void AddMappedElements(TArray<FControlRigComponentMappedElement> NewMappedElements) {}
	public  void AddMappedComponents(TArray<FControlRigComponentMappedComponent> Components) {}
	public  void AddMappedSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent,TArray<FControlRigComponentMappedBone> Bones,TArray<FControlRigComponentMappedCurve> Curves) {}
	public  void AddMappedCompleteSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent) {}
	public  void SetBoneInitialTransformsFromSkeletalMesh(USkeletalMesh InSkeletalMesh) {}
	public bool bEnableLazyEvaluation;
	public float LazyEvaluationPositionThreshold;
	public float LazyEvaluationRotationThreshold;
	public float LazyEvaluationScaleThreshold;
	public bool bResetTransformBeforeTick;
	public bool bResetInitialsBeforeConstruction;
	public bool bUpdateRigOnTick;
	public bool bUpdateInEditor;
	public bool bDrawBones;
	public bool bShowDebugDrawing;
	public  TArray<string> GetElementNames(ERigElementType ElementType/*=ERigElementType.Bone*/) { return default; }
	public  bool DoesElementExist(string Name,ERigElementType ElementType/*=ERigElementType.Bone*/) { return default; }
	public  FTransform GetBoneTransform(string BoneName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) { return default; }
	public  FTransform GetInitialBoneTransform(string BoneName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) { return default; }
	public  void SetBoneTransform(string BoneName,FTransform Transform,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/,float Weight/*=1.0f*/,bool bPropagateToChildren/*=true*/) {}
	public  void SetInitialBoneTransform(string BoneName,FTransform InitialTransform,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/,bool bPropagateToChildren/*=false*/) {}
	public  bool GetControlBool(string ControlName) { return default; }
	public  float GetControlFloat(string ControlName) { return default; }
	public  int GetControlInt(string ControlName) { return default; }
	public  FVector2D GetControlVector2D(string ControlName) { return default; }
	public  FVector GetControlPosition(string ControlName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.LocalSpace*/) { return default; }
	public  FRotator GetControlRotator(string ControlName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.LocalSpace*/) { return default; }
	public  FVector GetControlScale(string ControlName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.LocalSpace*/) { return default; }
	public  FTransform GetControlTransform(string ControlName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) { return default; }
	public  void SetControlBool(string ControlName,bool Value) {}
	public  void SetControlFloat(string ControlName,float Value) {}
	public  void SetControlInt(string ControlName,int Value) {}
	public  void SetControlVector2D(string ControlName,FVector2D Value) {}
	public  void SetControlPosition(string ControlName,FVector Value,EControlRigComponentSpace Space/*=EControlRigComponentSpace.LocalSpace*/) {}
	public  void SetControlRotator(string ControlName,FRotator Value,EControlRigComponentSpace Space/*=EControlRigComponentSpace.LocalSpace*/) {}
	public  void SetControlScale(string ControlName,FVector Value,EControlRigComponentSpace Space/*=EControlRigComponentSpace.LocalSpace*/) {}
	public  void SetControlTransform(string ControlName,FTransform Value,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) {}
	public  FTransform GetControlOffset(string ControlName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) { return default; }
	public  void SetControlOffset(string ControlName,FTransform OffsetTransform,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) {}
	public  FTransform GetSpaceTransform(string SpaceName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) { return default; }
	public  FTransform GetInitialSpaceTransform(string SpaceName,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) { return default; }
	public  void SetInitialSpaceTransform(string SpaceName,FTransform InitialTransform,EControlRigComponentSpace Space/*=EControlRigComponentSpace.RigSpace*/) {}
	public  void SetControlRigClass(UClass InControlRigClass) {}
	public  void SetObjectBinding(UObject InObjectToBind) {}
	public UControlRig ControlRig;
}
