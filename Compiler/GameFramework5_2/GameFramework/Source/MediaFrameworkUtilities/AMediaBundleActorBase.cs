#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A base actor that</summary>
[CppInclude("MediaBundleActorBase.h")]
public partial class AMediaBundleActorBase : AActor {
	///<summary>Get the Media Bundle.</summary>
	public  UMediaBundle GetMediaBundle() { return default; }
	///<summary>Play the Media Source.</summary>
	public  bool RequestOpenMediaSource() { return default; }
	///<summary>Close the Media Source.</summary>
	public  void RequestCloseMediaSource() {}
	///<summary>Assign the primitive to render on. Will change the material for the Media material.</summary>
	public  void SetComponent(UPrimitiveComponent InPrimitive,UMediaSoundComponent InMediaSound) {}
	///<summary>Texture containging 2D garbage matte mask</summary>
	public UTextureRenderTarget2D GarbageMatteMask;
	///<summary>Associated MediaBundle</summary>
	public UMediaBundle MediaBundle;
	///<summary>Wheter to auto start the MediaPlayer</summary>
	public bool bAutoPlay;
	///<summary>Wheter to keep MediaPlayer playing when editing</summary>
	public bool bPlayWhileEditing;
	///<summary>PrimitiveComponent on which to attach our Material</summary>
	public UPrimitiveComponent PrimitiveCmp;
	///<summary>MediaSoundComponent associated to play sound of our MediaSource</summary>
	public UMediaSoundComponent MediaSoundCmp;
	///<summary>Dynamic instance of the associated MediaBundle base Material</summary>
	public UMaterialInstanceDynamic Material;
	///<summary>Index of the Material on the primitive</summary>
	public int PrimitiveMaterialIndex;
}
