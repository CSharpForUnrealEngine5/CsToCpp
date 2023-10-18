namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionISMPoolDebugDrawComponent.h")]
public partial class UGeometryCollectionISMPoolDebugDrawComponent : UDebugDrawComponent {
	public static UClass StaticClass() {return default;}
	///<summary>bShowGlobalStats</summary>
	public bool bShowGlobalStats;
	///<summary>bShowStats</summary>
	public bool bShowStats;
	///<summary>bShowBounds</summary>
	public bool bShowBounds;
	///<summary>SelectedComponent</summary>
	public UInstancedStaticMeshComponent SelectedComponent;
}
