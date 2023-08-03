#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BuoyancyComponent.h")]
public partial class UBuoyancyComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>GetCurrentWaterBodyComponents</summary>
	public  TArray<UWaterBodyComponent> GetCurrentWaterBodyComponents() { return default; }
	///<summary>IsOverlappingWaterBody</summary>
	public  bool IsOverlappingWaterBody() { return default; }
	///<summary>IsInWaterBody</summary>
	public  bool IsInWaterBody() { return default; }
	///<summary>Pontoons_DEPRECATED</summary>
	public TArray<FSphericalPontoon> Pontoons_DEPRECATED;
	///<summary>OnPontoonEnteredWater</summary>
	public  void OnPontoonEnteredWater(FSphericalPontoon Pontoon) {}
	///<summary>OnPontoonExitedWater</summary>
	public  void OnPontoonExitedWater(FSphericalPontoon Pontoon) {}
	///<summary>OnEnteredWaterDelegate</summary>
	public FOnPontoonEnteredWater OnEnteredWaterDelegate;
	///<summary>OnExitedWaterDelegate</summary>
	public FOnPontoonExitedWater OnExitedWaterDelegate;
	///<summary>GetLastWaterSurfaceInfo</summary>
	public  void GetLastWaterSurfaceInfo(FVector OutWaterPlaneLocation,FVector OutWaterPlaneNormal,FVector OutWaterSurfacePosition,float OutWaterDepth,int OutWaterBodyIdx,FVector OutWaterVelocity) {}
	///<summary>BuoyancyData</summary>
	public FBuoyancyData BuoyancyData;
	///<summary>CurrentWaterBodyComponents</summary>
	public TArray<UWaterBodyComponent> CurrentWaterBodyComponents;
	///<summary>Primitive component that will be used for physics simulation.</summary>
	public UPrimitiveComponent SimulatingComponent;
}
