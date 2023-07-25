#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavigationPath.h")]
///<summary>UObject wrapper for FNavigationPath</summary>
public partial class UNavigationPath : UObject {
// NavigationPath
	public FOnNavigationPathUpdated PathUpdatedNotifier;
	public TArray<FVector> PathPoints;
	public byte RecalculateOnInvalidation;
	public string GetDebugString() { return default; }
	public void EnableDebugDrawing(bool bShouldDrawDebugData,FLinearColor PathColor/*=FLinearColor.White*/) {}
	public void EnableRecalculationOnInvalidation(byte DoRecalculation) {}
	public double GetPathLength() { return default; }
	public double GetPathCost() { return default; }
	public bool IsPartial() { return default; }
	public bool IsValid() { return default; }
	public bool IsStringPulled() { return default; }
}
