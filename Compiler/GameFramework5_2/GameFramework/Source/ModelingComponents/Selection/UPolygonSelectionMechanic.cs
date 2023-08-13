namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPolygonSelectionMechanic implements the interaction for selecting a set of faces/vertices/edges</summary>
[CppInclude("Selection/PolygonSelectionMechanic.h")]
public partial class UPolygonSelectionMechanic : UMeshTopologySelectionMechanic {
	public static UClass StaticClass() {return default;}
	///<summary>Properties_DEPRECATED</summary>
	public UDEPRECATED_PolygonSelectionMechanicProperties Properties_DEPRECATED;
}
