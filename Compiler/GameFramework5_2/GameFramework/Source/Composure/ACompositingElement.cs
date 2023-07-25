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
	public void SetElementName(string NewName) {}
	public bool IsSubElement() { return default; }
	public UObject GetElementParent() { return default; }
	public TArray<UObject> GetChildElements() { return default; }
	public float GetOpacity() { return default; }
	public void SetOpacity(float NewOpacity) {}
	public void SetEditorColorPickingTarget(UObject PickingTarget) {}
	public void SetEditorColorPickerDisplayImage(UObject PickerDisplayImage) {}
	public UObject RenderCompElement(bool bCameraCutThisFrame) { return default; }
	public FDynamicOnTransformPassRendered OnTransformPassRendered_BP;
	public FDynamicOnFinalPassRendered OnFinalPassRendered_BP;
	public string GetCompElementName() { return default; }
	public UObject RequestNamedRenderTarget(string ReferenceName,float RenderPercentage/*=1.0f*/,ETargetUsageFlags UsageTag/*=ETargetUsageFlags.USAGE_None*/) { return default; }
	public bool ReleaseOwnedTarget(UObject OwnedTarget) { return default; }
	public UObject RenderCompositingMaterial(FCompositingMaterial CompMaterial,float RenderScale/*=1.0f*/,string ResultLookupName/*=NAME_None*/,ETargetUsageFlags UsageTag/*=ETargetUsageFlags.USAGE_None*/) { return default; }
	public UObject RenderCompositingMaterialToTarget(FCompositingMaterial CompMaterial,UObject RenderTarget,string ResultLookupName/*=NAME_None*/) { return default; }
	public UObject FindTargetCamera() { return default; }
	public void SetTargetCamera(UObject NewCameraActor) {}
	public void RegisterPassResult(string ReferenceName,UObject PassResult,bool bSetAsLatestRenderResult/*=true*/) {}
	public UObject FindNamedRenderResult(string PassName,bool bSearchSubElements/*=true*/) { return default; }
	public UObject GetLatestRenderResult() { return default; }
	public FIntPoint GetRenderResolution() { return default; }
	public void SetRenderResolution(FIntPoint NewResolution) {}
	public UObject FindInputPass(UClass InputType,UObject PassResult,string OptionalPassName/*=NAME_None*/) { return default; }
	public UObject FindTransformPass(UClass TransformType,UObject PassResult,string OptionalPassName/*=NAME_None*/) { return default; }
	public UObject FindOutputPass(UClass OutputType,string OptionalPassName/*=NAME_None*/) { return default; }
	public TArray<UObject> GetInputsList() { return default; }
	public TArray<UObject> GetTransformsList() { return default; }
	public TArray<UObject> GetOutputsList() { return default; }
	public bool DeletePass(UObject PassToDelete) { return default; }
	public UObject CreateNewInputPass(string PassName,UClass InputType) { return default; }
	public UObject CreateNewTransformPass(string PassName,UClass TransformType) { return default; }
	public UObject CreateNewOutputPass(string PassName,UClass OutputType) { return default; }
	public UObject AddNewInputPass(string PassName,UClass InputType) { return default; }
	public UObject AddNewTransformPass(string PassName,UClass TransformType) { return default; }
	public UObject AddNewOutputPass(string PassName,UClass OutputType) { return default; }
	public int GetRenderPriority() { return default; }
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
