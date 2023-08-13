namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A UBlueprint child class for the RenderGrid modules.</summary>
[CppInclude("Blueprints/RenderGridBlueprint.h")]
public partial class URenderGridBlueprint : UBlueprint {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the RenderGrid reference that this RenderGrid asset contains. This is simply the data representation of the render grid, meaning that it won&#39;t contain a blueprint graph or any user code.</summary>
	public URenderGrid GetRenderGrid() { return default; }
	///<summary>Returns the RenderGrid reference that this RenderGrid asset contains. This will be the subclass of the blueprint class, meaning it will contain a blueprint graph.</summary>
	public URenderGrid GetRenderGridWithBlueprintGraph() { return default; }
	///<summary>Returns the RenderGrid reference that this RenderGrid asset contains. This will be the default object of the subclass of the blueprint class, meaning it will contain a blueprint graph.</summary>
	public URenderGrid GetRenderGridClassDefaultObject() { return default; }
	///<summary>RenderGrid</summary>
	public URenderGrid RenderGrid;
}
