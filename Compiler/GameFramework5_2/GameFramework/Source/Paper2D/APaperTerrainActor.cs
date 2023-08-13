namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An instance of a piece of 2D terrain in the level</summary>
[CppInclude("PaperTerrainActor.h")]
public partial class APaperTerrainActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>DummyRoot</summary>
	public USceneComponent DummyRoot;
	///<summary>SplineComponent</summary>
	public UPaperTerrainSplineComponent SplineComponent;
	///<summary>RenderComponent</summary>
	public UPaperTerrainComponent RenderComponent;
}
