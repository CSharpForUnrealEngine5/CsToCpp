namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>CanvasRenderTarget2D is 2D render target which exposes a Canvas interface to allow you to draw elements onto</summary>
[CppInclude("Engine/CanvasRenderTarget2D.h")]
public partial class UCanvasRenderTarget2D : UTextureRenderTarget2D {
	public static UClass StaticClass() {return default;}
	///<summary>Updates the the canvas render target texture&#39;s resource. This is where the render target will create or</summary>
	public virtual void UpdateResource() {}
	///<summary>Creates a new canvas render target and initializes it to the specified dimensions</summary>
	public static UCanvasRenderTarget2D CreateCanvasRenderTarget2D(UObject WorldContextObject,UClass CanvasRenderTarget2DClass,int Width/*=1024*/,int Height/*=1024*/) { return default; }
	///<summary>Allows a Blueprint to implement how this Canvas Render Target 2D should be updated.</summary>
	public void ReceiveUpdate(UCanvas Canvas,int Width,int Height) {}
	///<summary>Gets a specific render target&#39;s size from the global map of canvas render targets.</summary>
	public void GetSize(int Width,int Height) {}
	///<summary>Called when this Canvas Render Target is asked to update its texture resource.</summary>
	public FOnCanvasRenderTargetUpdate OnCanvasRenderTargetUpdate;
	///<summary>The world this render target will be used with</summary>
	public TWeakObjectPtr<UWorld> World;
	///<summary>If true, clear the render target to green whenever OnReceiveUpdate() is called.  (Defaults to true.)</summary>
	public bool bShouldClearRenderTargetOnReceiveUpdate;
}
