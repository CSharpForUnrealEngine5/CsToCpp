namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElement.h")]
public partial class ACompositingElement : AComposurePipelineBaseActor {
	public static UClass StaticClass() {return default;}
	///<summary>CompositingTarget</summary>
	public UComposureCompositingTargetComponent CompositingTarget;
	///<summary>PostProcessProxy</summary>
	public UComposurePostProcessingPassProxy PostProcessProxy;
	///<summary>*****************************// Pipeline Passes</summary>
	public TArray<UCompositingElementInput> Inputs;
	///<summary>TransformPasses</summary>
	public TArray<UCompositingElementTransform> TransformPasses;
	///<summary>Outputs</summary>
	public TArray<UCompositingElementOutput> Outputs;
	///<summary>*****************************// Inputs</summary>
	public ESceneCameraLinkType CameraSource;
	///<summary>TargetCameraActor</summary>
	public TLazyObjectPtr<ACameraActor> TargetCameraActor;
	///<summary>*****************************// Outputs</summary>
	public EInheritedSourceType ResolutionSource;
	///<summary>RenderResolution</summary>
	public FIntPoint RenderResolution;
	///<summary>RenderFormat</summary>
	public ETextureRenderTargetFormat RenderFormat;
	///<summary>bUseSharedTargetPool</summary>
	public bool bUseSharedTargetPool;
	///<summary>BlueprintReadWrite, Category = &quot;Composure&quot;,</summary>
	public int FreezeFrameMask;
	///<summary>PreviewTransformSource</summary>
	public EInheritedSourceType PreviewTransformSource;
	///<summary>PreviewTransform</summary>
	public UCompositingElementTransform PreviewTransform;
	///<summary>DefaultInputType</summary>
	public UClass DefaultInputType;
	///<summary>DefaultTransformType</summary>
	public UClass DefaultTransformType;
	///<summary>DefaultOutputType</summary>
	public UClass DefaultOutputType;
	///<summary>Rename composure actor&#39;s name</summary>
	public void SetElementName(FName NewName) {}
	///<summary>Determines whether current composure element is a child of another composure element or not.</summary>
	public bool IsSubElement() { return default; }
	///<summary>Get the parent composure element of current element.</summary>
	public ACompositingElement GetElementParent() { return default; }
	///<summary>Get the first level of current element&#39;s child composure elements.</summary>
	public TArray<ACompositingElement> GetChildElements() { return default; }
	///<summary>Return the rendering opacity of current composure actor.</summary>
	public float GetOpacity() { return default; }
	///<summary>Set the rendering opacity of current composure actor.</summary>
	public void SetOpacity(float NewOpacity) {}
	///<summary>EDITOR ONLY - Specifies which intermediate target to pick colors from (if left unset, we default to the display image)</summary>
	public void SetEditorColorPickingTarget(UTextureRenderTarget2D PickingTarget) {}
	///<summary>EDITOR ONLY - Specifies an intermediate image to display when picking (if left unset, we default to the final output image)</summary>
	public void SetEditorColorPickerDisplayImage(UTexture PickerDisplayImage) {}
	///<summary>RenderCompElement</summary>
	public UTexture RenderCompElement(bool bCameraCutThisFrame) { return default; }
	///<summary>Called when a transform pass on this element is rendered</summary>
	public FDynamicOnTransformPassRendered OnTransformPassRendered_BP;
	///<summary>Called when the final output of this element is rendered</summary>
	public FDynamicOnFinalPassRendered OnFinalPassRendered_BP;
	///<summary>Return the FName of the composure element object</summary>
	public FName GetCompElementName() { return default; }
	///<summary>RequestNamedRenderTarget</summary>
	public UTextureRenderTarget2D RequestNamedRenderTarget(FName ReferenceName,float RenderPercentage/*=1.0f*/,ETargetUsageFlags UsageTag/*=ETargetUsageFlags.USAGE_None*/) { return default; }
	///<summary>ReleaseOwnedTarget</summary>
	public bool ReleaseOwnedTarget(UTextureRenderTarget2D OwnedTarget) { return default; }
	///<summary>RenderCompositingMaterial</summary>
	public UTexture RenderCompositingMaterial(FCompositingMaterial CompMaterial,float RenderScale/*=1.0f*/,FName ResultLookupName/*=NAME_None*/,ETargetUsageFlags UsageTag/*=ETargetUsageFlags.USAGE_None*/) { return default; }
	///<summary>RenderCompositingMaterialToTarget</summary>
	public UTextureRenderTarget2D RenderCompositingMaterialToTarget(FCompositingMaterial CompMaterial,UTextureRenderTarget2D RenderTarget,FName ResultLookupName/*=NAME_None*/) { return default; }
	///<summary>FindTargetCamera</summary>
	public ACameraActor FindTargetCamera() { return default; }
	///<summary>SetTargetCamera</summary>
	public void SetTargetCamera(ACameraActor NewCameraActor) {}
	///<summary>RegisterPassResult</summary>
	public void RegisterPassResult(FName ReferenceName,UTexture PassResult,bool bSetAsLatestRenderResult/*=true*/) {}
	///<summary>FindNamedRenderResult</summary>
	public UTexture FindNamedRenderResult(FName PassName,bool bSearchSubElements/*=true*/) { return default; }
	///<summary>const;</summary>
	public UTexture GetLatestRenderResult() { return default; }
	///<summary>GetRenderResolution</summary>
	public FIntPoint GetRenderResolution() { return default; }
	///<summary>SetRenderResolution</summary>
	public void SetRenderResolution(FIntPoint NewResolution) {}
	///<summary>*****************************// Pass Management</summary>
	public UCompositingElementInput FindInputPass(UClass InputType,UTexture PassResult,FName OptionalPassName/*=NAME_None*/) { return default; }
	///<summary>FindTransformPass</summary>
	public UCompositingElementTransform FindTransformPass(UClass TransformType,UTexture PassResult,FName OptionalPassName/*=NAME_None*/) { return default; }
	///<summary>FindOutputPass</summary>
	public UCompositingElementOutput FindOutputPass(UClass OutputType,FName OptionalPassName/*=NAME_None*/) { return default; }
	///<summary>GetInputsList</summary>
	public TArray<UCompositingElementInput> GetInputsList() { return default; }
	///<summary>GetTransformsList</summary>
	public TArray<UCompositingElementTransform> GetTransformsList() { return default; }
	///<summary>GetOutputsList</summary>
	public TArray<UCompositingElementOutput> GetOutputsList() { return default; }
	///<summary>Delete a specific pass. This function deals with the public list where deletion is directly reflected in the editor.</summary>
	public bool DeletePass(UCompositingElementPass PassToDelete) { return default; }
	///<summary>Create a new input pass into the public list which directly shows in the editor.</summary>
	public UCompositingElementInput CreateNewInputPass(FName PassName,UClass InputType) { return default; }
	///<summary>Create a new Transform pass into the public list which directly shows in the editor.</summary>
	public UCompositingElementTransform CreateNewTransformPass(FName PassName,UClass TransformType) { return default; }
	///<summary>Create a new Output pass into the public list which directly shows in the editor.</summary>
	public UCompositingElementOutput CreateNewOutputPass(FName PassName,UClass OutputType) { return default; }
	///<summary>AddNewInputPass</summary>
	public UCompositingElementInput AddNewInputPass(FName PassName,UClass InputType) { return default; }
	///<summary>AddNewTransformPass</summary>
	public UCompositingElementTransform AddNewTransformPass(FName PassName,UClass TransformType) { return default; }
	///<summary>AddNewOutputPass</summary>
	public UCompositingElementOutput AddNewOutputPass(FName PassName,UClass OutputType) { return default; }
	///<summary>GetRenderPriority</summary>
	public virtual int GetRenderPriority() { return default; }
	///<summary>CompShotIdName</summary>
	public FName CompShotIdName;
	///<summary>Parent</summary>
	public ACompositingElement Parent;
	///<summary>ChildLayers</summary>
	public TArray<ACompositingElement> ChildLayers;
	///<summary>DisabledMsgImage</summary>
	public UTexture DisabledMsgImage;
	///<summary>EmptyWarnImage</summary>
	public UTexture EmptyWarnImage;
	///<summary>SuspendedDbgImage</summary>
	public UTexture SuspendedDbgImage;
	///<summary>CompilerErrImage</summary>
	public UTexture CompilerErrImage;
	///<summary>bUsingDebugDisplayImage</summary>
	public bool bUsingDebugDisplayImage;
	///<summary>ColorPickerDisplayImage</summary>
	public UTexture ColorPickerDisplayImage;
	///<summary>EditorPreviewImage</summary>
	public UTexture EditorPreviewImage;
	///<summary>ColorPickerTarget</summary>
	public UTextureRenderTarget2D ColorPickerTarget;
	///<summary>OutputOpacity</summary>
	public float OutputOpacity;
	///<summary>Lists containing passes added programatically (or through Blueprints) via the AddNewPass() functions.</summary>
	public TMap<UCompositingElementInput,ECompPassConstructionType> UserConstructedInputs;
	///<summary>UserConstructedTransforms</summary>
	public TMap<UCompositingElementTransform,ECompPassConstructionType> UserConstructedTransforms;
	///<summary>UserConstructedOutputs</summary>
	public TMap<UCompositingElementOutput,ECompPassConstructionType> UserConstructedOutputs;
	///<summary>Authoritative lists that we use to iterate on the passes - conjoined from the public lists and the</summary>
	public TArray<UCompositingElementInput> InternalInputs;
	///<summary>InternalTransformPasses</summary>
	public TArray<UCompositingElementTransform> InternalTransformPasses;
	///<summary>InternalOutputs</summary>
	public TArray<UCompositingElementOutput> InternalOutputs;
	///<summary>InternalAlphaPass</summary>
	public UAlphaTransformPass InternalAlphaPass;
}
