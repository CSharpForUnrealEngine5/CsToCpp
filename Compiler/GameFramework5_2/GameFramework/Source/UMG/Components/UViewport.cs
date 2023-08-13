namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/Viewport.h")]
public partial class UViewport : UContentWidget {
	public static UClass StaticClass() {return default;}
	///<summary>BackgroundColor</summary>
	public FLinearColor BackgroundColor;
	///<summary>GetViewportWorld</summary>
	public UWorld GetViewportWorld() { return default; }
	///<summary>GetViewLocation</summary>
	public FVector GetViewLocation() { return default; }
	///<summary>SetViewLocation</summary>
	public void SetViewLocation(FVector Location) {}
	///<summary>GetViewRotation</summary>
	public FRotator GetViewRotation() { return default; }
	///<summary>SetViewRotation</summary>
	public void SetViewRotation(FRotator Rotation) {}
	///<summary>Spawn</summary>
	public AActor Spawn(UClass ActorClass) { return default; }
}
