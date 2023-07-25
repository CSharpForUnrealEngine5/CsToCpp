#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/RuntimeVirtualTextureComponent.h")]
///<summary>Component used to place a URuntimeVirtualTexture in the world.</summary>
public partial class URuntimeVirtualTextureComponent : USceneComponent {
// RuntimeVirtualTextureComponent
	public TSoftObjectPtr<AActor> BoundsAlignActor;
	public bool bSetBoundsButton;
	public bool bSnapBoundsToLandscape;
	public URuntimeVirtualTexture VirtualTexture;
	public bool bEnableScalability;
	public uint ScalabilityGroup;
	public bool bHidePrimitives;
	public UVirtualTextureBuilder StreamingTexture;
	public int StreamLowMips;
	public bool bBuildStreamingMipsButton;
	public byte LossyCompressionAmount;
	public bool bUseStreamingLowMipsInEditor;
	public bool bBuildDebugStreamingMips;
	public void Invalidate(FBoxSphereBounds WorldBounds) {}
}
