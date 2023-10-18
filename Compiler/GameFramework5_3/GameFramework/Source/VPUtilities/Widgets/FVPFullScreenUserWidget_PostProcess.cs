namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Renders widget by adding it as a blend material.</summary>
[CppInclude("Widgets/Fullscreen/VPFullScreenUserWidget_PostProcess.h")]
public partial struct FVPFullScreenUserWidget_PostProcess {
	public TArray<ACompositingElement> ComposureLayerTargets;
	public UPostProcessComponent PostProcessComponent;
	public UMaterialInstanceDynamic PostProcessMaterialInstance;
}
