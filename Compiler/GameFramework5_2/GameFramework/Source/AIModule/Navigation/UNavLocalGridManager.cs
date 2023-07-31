#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Manager for local navigation grids</summary>
[CppInclude("Navigation/NavLocalGridManager.h")]
public partial class UNavLocalGridManager : UObject {
	///<summary>SetLocalNavigationGridDensity</summary>
	public static bool SetLocalNavigationGridDensity(UObject WorldContextObject,float CellSize) { return default; }
	///<summary>creates new grid data for single point</summary>
	public static int AddLocalNavigationGridForPoint(UObject WorldContextObject,FVector Location,int Radius2D/*=5*/,float Height/*=100.0f*/,bool bRebuildGrids/*=true*/) { return default; }
	///<summary>creates single grid data for set of points</summary>
	public static int AddLocalNavigationGridForPoints(UObject WorldContextObject,TArray<FVector> Locations,int Radius2D/*=5*/,float Height/*=100.0f*/,bool bRebuildGrids/*=true*/) { return default; }
	///<summary>AddLocalNavigationGridForBox</summary>
	public static int AddLocalNavigationGridForBox(UObject WorldContextObject,FVector Location,FVector Extent/*=new FVector(1,1,1)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,int Radius2D/*=5*/,float Height/*=100.0f*/,bool bRebuildGrids/*=true*/) { return default; }
	///<summary>AddLocalNavigationGridForCapsule</summary>
	public static int AddLocalNavigationGridForCapsule(UObject WorldContextObject,FVector Location,float CapsuleRadius,float CapsuleHalfHeight,int Radius2D/*=5*/,float Height/*=100.0f*/,bool bRebuildGrids/*=true*/) { return default; }
	///<summary>RemoveLocalNavigationGrid</summary>
	public static void RemoveLocalNavigationGrid(UObject WorldContextObject,int GridId,bool bRebuildGrids/*=true*/) {}
	///<summary>FindLocalNavigationGridPath</summary>
	public static bool FindLocalNavigationGridPath(UObject WorldContextObject,FVector Start,FVector End,TArray<FVector> PathPoints) { return default; }
}
