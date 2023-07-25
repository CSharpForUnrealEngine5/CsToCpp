#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/Viewport.h")]
public partial class UViewport : UContentWidget {
// Viewport
	public FLinearColor BackgroundColor;
	public UObject GetViewportWorld() { return default; }
	public FVector GetViewLocation() { return default; }
	public void SetViewLocation(FVector Location) {}
	public FRotator GetViewRotation() { return default; }
	public void SetViewRotation(FRotator Rotation) {}
	public UObject Spawn(UClass ActorClass) { return default; }
}
