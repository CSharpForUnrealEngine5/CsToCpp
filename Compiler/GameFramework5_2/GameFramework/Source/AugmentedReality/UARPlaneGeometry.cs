#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARPlaneGeometry : UARTrackedGeometry {
// ARPlaneGeometry
	public  FVector GetCenter() { return default; }
	public  FVector GetExtent() { return default; }
	public  TArray<FVector> GetBoundaryPolygonInLocalSpace() { return default; }
	public  UARPlaneGeometry GetSubsumedBy() { return default; }
	public  EARPlaneOrientation GetOrientation() { return default; }
	public EARPlaneOrientation Orientation;
	public FVector Center;
	public FVector Extent;
	public TArray<FVector> BoundaryPolygon;
	public UARPlaneGeometry SubsumedBy;
}
