#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/CanvasRenderTarget2D.h")]
///<summary>CanvasRenderTarget2D is 2D render target which exposes a Canvas interface to allow you to draw elements onto</summary>
public partial class UCanvasRenderTarget2D : UTextureRenderTarget2D {
// CanvasRenderTarget2D
	public void UpdateResource() {}
	public UObject CreateCanvasRenderTarget2D(UObject WorldContextObject,UClass CanvasRenderTarget2DClass,int Width/*=1024*/,int Height/*=1024*/) { return default; }
	public void ReceiveUpdate(UObject Canvas,int Width,int Height) {}
	public void GetSize(int Width,int Height) {}
	public FOnCanvasRenderTargetUpdate OnCanvasRenderTargetUpdate;
	public TWeakObjectPtr<UWorld> World;
	public bool bShouldClearRenderTargetOnReceiveUpdate;
}
