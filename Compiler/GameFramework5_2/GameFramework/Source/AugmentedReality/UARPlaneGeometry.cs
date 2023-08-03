#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARPlaneGeometry : UARTrackedGeometry {
	public static UClass StaticClass() {return default;}
	///<summary>GetCenter</summary>
	public  FVector GetCenter() { return default; }
	///<summary>GetExtent</summary>
	public  FVector GetExtent() { return default; }
	///<summary>GetBoundaryPolygonInLocalSpace</summary>
	public  TArray<FVector> GetBoundaryPolygonInLocalSpace() { return default; }
	///<summary>GetSubsumedBy</summary>
	public  UARPlaneGeometry GetSubsumedBy() { return default; }
	///<summary>GetOrientation</summary>
	public  EARPlaneOrientation GetOrientation() { return default; }
	///<summary>Orientation</summary>
	public EARPlaneOrientation Orientation;
	///<summary>Center</summary>
	public FVector Center;
	///<summary>Extent</summary>
	public FVector Extent;
	///<summary>BoundaryPolygon</summary>
	public TArray<FVector> BoundaryPolygon;
	///<summary>Used by ARCore Only</summary>
	public UARPlaneGeometry SubsumedBy;
}
