#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGPointData.h")]
///<summary>TODO: Split this in "concrete" vs "api" class (needed for views)</summary>
public partial class UPCGPointData : UPCGSpatialData {
// PCGPointData
	public  TArray<FPCGPoint> GetPoints() { return default; }
	public  FPCGPoint GetPoint(int Index) { return default; }
	public  void SetPoints(TArray<FPCGPoint> InPoints) {}
	public  void CopyPointsFrom(UPCGPointData InData,TArray<int> InDataIndices) {}
	public TArray<FPCGPoint> Points;
}
