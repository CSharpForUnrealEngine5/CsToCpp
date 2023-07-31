#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/DisplayClusterBlueprintContainers.h")]
public partial struct FDisplayClusterViewportContext {
	public string ViewportID;
	public FIntPoint RectLocation;
	public FIntPoint RectSize;
	public FVector ViewLocation;
	public FRotator ViewRotation;
	public FMatrix ProjectionMatrix;
	public bool bIsRendering;
}
