namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UObject wrapper for FNavigationPath</summary>
[CppInclude("NavigationPath.h")]
public partial class UNavigationPath : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>PathUpdatedNotifier</summary>
	public FOnNavigationPathUpdated PathUpdatedNotifier;
	///<summary>PathPoints</summary>
	public TArray<FVector> PathPoints;
	///<summary>RecalculateOnInvalidation</summary>
	public ENavigationOptionFlag RecalculateOnInvalidation;
	///<summary>UObject end</summary>
	public string GetDebugString() { return default; }
	///<summary>EnableDebugDrawing</summary>
	public void EnableDebugDrawing(bool bShouldDrawDebugData,FLinearColor PathColor/*=FLinearColor.White*/) {}
	///<summary>if enabled path will request recalculation if it gets invalidated due to a change to underlying navigation</summary>
	public void EnableRecalculationOnInvalidation(ENavigationOptionFlag DoRecalculation) {}
	///<summary>GetPathLength</summary>
	public double GetPathLength() { return default; }
	///<summary>GetPathCost</summary>
	public double GetPathCost() { return default; }
	///<summary>IsPartial</summary>
	public bool IsPartial() { return default; }
	///<summary>IsValid</summary>
	public bool IsValid() { return default; }
	///<summary>IsStringPulled</summary>
	public bool IsStringPulled() { return default; }
}
