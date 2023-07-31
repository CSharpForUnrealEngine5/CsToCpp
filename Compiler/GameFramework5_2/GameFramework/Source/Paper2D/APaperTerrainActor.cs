#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An instance of a piece of 2D terrain in the level</summary>
[CppInclude("PaperTerrainActor.h")]
public partial class APaperTerrainActor : AActor {
	///<summary>DummyRoot</summary>
	public USceneComponent DummyRoot;
	///<summary>SplineComponent</summary>
	public UPaperTerrainSplineComponent SplineComponent;
	///<summary>RenderComponent</summary>
	public UPaperTerrainComponent RenderComponent;
}
