#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows tools to interact with the 2d preview viewport</summary>
[CppInclude("ContextObjects/UVToolContextObjects.h")]
public partial class UUVTool2DViewportAPI : UUVToolContextObject {
	///<summary>UDIMBlocks</summary>
	public TArray<FUDIMBlock> UDIMBlocks;
	///<summary>bDrawGrid</summary>
	public bool bDrawGrid;
	///<summary>bDrawRulers</summary>
	public bool bDrawRulers;
}
