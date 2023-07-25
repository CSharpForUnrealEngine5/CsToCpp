#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/DisplayClusterBlueprintContainers.h")]
public partial struct FDisplayClusterViewportStereoContext {
// DisplayClusterViewportStereoContext
	public string ViewportID;
	public FIntPoint RectLocation;
	public FIntPoint RectSize;
	public TArray<FVector> ViewLocation;
	public TArray<FRotator> ViewRotation;
	public TArray<FMatrix> ProjectionMatrix;
	public bool bIsRendering;
}
