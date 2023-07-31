#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component used to place a URuntimeVirtualTexture in the world.</summary>
[CppInclude("Components/RuntimeVirtualTextureComponent.h")]
public partial class URuntimeVirtualTextureComponent : USceneComponent {
	///<summary>Actor to align rotation to. If set this actor is always included in the bounds calculation.</summary>
	public TSoftObjectPtr<AActor> BoundsAlignActor;
	///<summary>Placeholder for details customization button.</summary>
	public bool bSetBoundsButton;
	///<summary>If the Bounds Align Actor is a Landscape then this will snap the bounds so that virtual texture texels align with landscape vertex positions.</summary>
	public bool bSnapBoundsToLandscape;
	///<summary>The virtual texture object to use.</summary>
	public URuntimeVirtualTexture VirtualTexture;
	///<summary>Set to true to enable scalability settings for the virtual texture.</summary>
	public bool bEnableScalability;
	///<summary>Group index of the scalability settings to use for the virtual texture.</summary>
	public uint ScalabilityGroup;
	///<summary>Hide primitives in the main pass. Hidden primitives will be those that draw to this virtual texture with &#39;Draw in Main Pass&#39; set to &#39;From Virtual Texture&#39;.</summary>
	public bool bHidePrimitives;
	///<summary>Texture object containing streamed low mips. This can reduce rendering update cost.</summary>
	public UVirtualTextureBuilder StreamingTexture;
	///<summary>Number of streaming low mips to build for the virtual texture.</summary>
	public int StreamLowMips;
	///<summary>Placeholder for details customization button.</summary>
	public bool bBuildStreamingMipsButton;
	///<summary>How aggressively should any relevant lossy compression be applied.</summary>
	public ETextureLossyCompressionAmount LossyCompressionAmount;
	///<summary>Use streaming low mips when rendering in editor. Set true to view and debug the baked streaming low mips.</summary>
	public bool bUseStreamingLowMipsInEditor;
	///<summary>Build the streaming low mips using debug coloring. This can help show where streaming mips are being used.</summary>
	public bool bBuildDebugStreamingMips;
	///<summary>This function marks an area of the runtime virtual texture as dirty.</summary>
	public  void Invalidate(FBoxSphereBounds WorldBounds) {}
}
