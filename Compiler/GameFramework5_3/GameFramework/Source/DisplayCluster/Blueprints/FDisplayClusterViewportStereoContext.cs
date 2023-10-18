namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/DisplayClusterBlueprintContainers.h")]
public partial struct FDisplayClusterViewportStereoContext {
	public string ViewportID;
	public FIntPoint RectLocation;
	public FIntPoint RectSize;
	public TArray<FVector> ViewLocation;
	public TArray<FRotator> ViewRotation;
	public TArray<FMatrix> ProjectionMatrix;
	public bool bIsRendering;
}
