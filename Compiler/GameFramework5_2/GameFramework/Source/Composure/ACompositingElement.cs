#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElement.h")]
public partial class ACompositingElement : AComposurePipelineBaseActor {
// CompositingElement
	public UComposureCompositingTargetComponent CompositingTarget;
	public UComposurePostProcessingPassProxy PostProcessProxy;
	public TArray<UCompositingElementInput> Inputs;
	public TArray<UCompositingElementTransform> TransformPasses;
	public TArray<UCompositingElementOutput> Outputs;
	public ESceneCameraLinkType CameraSource;
	public TLazyObjectPtr<ACameraActor> TargetCameraActor;
	public EInheritedSourceType ResolutionSource;
	public FIntPoint RenderResolution;
	public byte RenderFormat;
	public bool bUseSharedTargetPool;
	public int FreezeFrameMask;
	public EInheritedSourceType PreviewTransformSource;
	public UCompositingElementTransform PreviewTransform;
	public UClass DefaultInputType;
	public UClass DefaultTransformType;
	public UClass DefaultOutputType;
	public  void SetElementName(string NewName) {}
	public  bool IsSubElement() { return default; }
	public  ACompositingElement GetElementParent() { return default; }
	public  TArray<ACompositingElement> GetChildElements() { return default; }
	public  float GetOpacity() { return default; }
	public  void SetOpacity(float NewOpacity) {}
	public  void SetEditorColorPickingTarget(UTextureRenderTarget2D PickingTarget) {}
	public  void SetEditorColorPickerDisplayImage(UTexture PickerDisplayImage) {}
	public  UTexture RenderCompElement(bool bCameraCutThisFrame) { return default; }
	public FDynamicOnTransformPassRendered OnTransformPassRendered_BP;
	public FDynamicOnFinalPassRendered OnFinalPassRendered_BP;
	public  string GetCompElementName() { return default; }
	public  UTextureRenderTarget2D RequestNamedRenderTarget(string ReferenceName,float RenderPercentage/*=1.0f*/,ETargetUsageFlags UsageTag/*=ETargetUsageFlags.USAGE_None*/) { return default; }
	public  bool ReleaseOwnedTarget(UTextureRenderTarget2D OwnedTarget) { return default; }
	public  UTexture RenderCompositingMaterial(FCompositingMaterial CompMaterial,float RenderScale/*=1.0f*/,string ResultLookupName/*=NAME_None*/,ETargetUsageFlags UsageTag/*=ETargetUsageFlags.USAGE_None*/) { return default; }
	public  UTextureRenderTarget2D RenderCompositingMaterialToTarget(FCompositingMaterial CompMaterial,UTextureRenderTarget2D RenderTarget,string ResultLookupName/*=NAME_None*/) { return default; }
	public  ACameraActor FindTargetCamera() { return default; }
	public  void SetTargetCamera(ACameraActor NewCameraActor) {}
	public  void RegisterPassResult(string ReferenceName,UTexture PassResult,bool bSetAsLatestRenderResult/*=true*/) {}
	public  UTexture FindNamedRenderResult(string PassName,bool bSearchSubElements/*=true*/) { return default; }
	public  UTexture GetLatestRenderResult() { return default; }
	public  FIntPoint GetRenderResolution() { return default; }
	public  void SetRenderResolution(FIntPoint NewResolution) {}
	public  UCompositingElementInput FindInputPass(UClass InputType,UTexture PassResult,string OptionalPassName/*=NAME_None*/) { return default; }
	public  UCompositingElementTransform FindTransformPass(UClass TransformType,UTexture PassResult,string OptionalPassName/*=NAME_None*/) { return default; }
	public  UCompositingElementOutput FindOutputPass(UClass OutputType,string OptionalPassName/*=NAME_None*/) { return default; }
	public  TArray<UCompositingElementInput> GetInputsList() { return default; }
	public  TArray<UCompositingElementTransform> GetTransformsList() { return default; }
	public  TArray<UCompositingElementOutput> GetOutputsList() { return default; }
	public  bool DeletePass(UCompositingElementPass PassToDelete) { return default; }
	public  UCompositingElementInput CreateNewInputPass(string PassName,UClass InputType) { return default; }
	public  UCompositingElementTransform CreateNewTransformPass(string PassName,UClass TransformType) { return default; }
	public  UCompositingElementOutput CreateNewOutputPass(string PassName,UClass OutputType) { return default; }
	public  UCompositingElementInput AddNewInputPass(string PassName,UClass InputType) { return default; }
	public  UCompositingElementTransform AddNewTransformPass(string PassName,UClass TransformType) { return default; }
	public  UCompositingElementOutput AddNewOutputPass(string PassName,UClass OutputType) { return default; }
	public  int GetRenderPriority() { return default; }
	public string CompShotIdName;
	public ACompositingElement Parent;
	public TArray<ACompositingElement> ChildLayers;
	public UTexture DisabledMsgImage;
	public UTexture EmptyWarnImage;
	public UTexture SuspendedDbgImage;
	public UTexture CompilerErrImage;
	public bool bUsingDebugDisplayImage;
	public UTexture ColorPickerDisplayImage;
	public UTexture EditorPreviewImage;
	public UTextureRenderTarget2D ColorPickerTarget;
	public float OutputOpacity;
	public TMap<UCompositingElementInput,ECompPassConstructionType> UserConstructedInputs;
	public TMap<UCompositingElementTransform,ECompPassConstructionType> UserConstructedTransforms;
	public TMap<UCompositingElementOutput,ECompPassConstructionType> UserConstructedOutputs;
	public TArray<UCompositingElementInput> InternalInputs;
	public TArray<UCompositingElementTransform> InternalTransformPasses;
	public TArray<UCompositingElementOutput> InternalOutputs;
	public UAlphaTransformPass InternalAlphaPass;
}
