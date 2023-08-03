#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshVertexColorFunctions.h")]
public partial class UGeometryScriptLibrary_MeshVertexColorFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Set all vertex colors (optionally specific channels) in the TargetMesh VertexColor Overlay to a constant value</summary>
	public static UDynamicMesh SetMeshConstantVertexColor(UDynamicMesh TargetMesh,FLinearColor Color,FGeometryScriptColorFlags Flags,bool bClearExisting/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Set the colors in the TargetMesh VertexColor Overlay identified by the Selection to a constant value.</summary>
	public static UDynamicMesh SetMeshSelectionVertexColor(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FLinearColor Color,FGeometryScriptColorFlags Flags,bool bCreateColorSeam/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Set all vertex colors in the TargetMesh VertexColor Overlay to the specified per-vertex colors</summary>
	public static UDynamicMesh SetMeshPerVertexColors(UDynamicMesh TargetMesh,FGeometryScriptColorList VertexColorList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Get a list of single vertex colors for each mesh vertex in the TargetMesh, derived from the VertexColor Overlay.</summary>
	public static UDynamicMesh GetMeshPerVertexColors(UDynamicMesh TargetMesh,FGeometryScriptColorList ColorList,bool bIsValidColorSet,bool bHasVertexIDGaps,bool bBlendSplitVertexValues/*=true*/) { return default; }
	///<summary>Apply a SRGB to Linear color transformation on all vertex colors</summary>
	public static UDynamicMesh ConvertMeshVertexColorsSRGBToLinear(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Apply a Linear to SRGB color transformation on all vertex colors</summary>
	public static UDynamicMesh ConvertMeshVertexColorsLinearToSRGB(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
