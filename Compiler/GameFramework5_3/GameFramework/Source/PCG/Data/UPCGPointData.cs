namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TODO: Split this in &quot;concrete&quot; vs &quot;api&quot; class (needed for views)</summary>
[CppInclude("Data/PCGPointData.h")]
public partial class UPCGPointData : UPCGSpatialData {
	public static UClass StaticClass() {return default;}
	///<summary>GetPoints</summary>
	public TArray<FPCGPoint> GetPoints() { return default; }
	///<summary>GetPoint</summary>
	public FPCGPoint GetPoint(int Index) { return default; }
	///<summary>SetPoints</summary>
	public void SetPoints(TArray<FPCGPoint> InPoints) {}
	///<summary>CopyPointsFrom</summary>
	public void CopyPointsFrom(UPCGPointData InData,TArray<int> InDataIndices) {}
	///<summary>Points</summary>
	public TArray<FPCGPoint> Points;
}
