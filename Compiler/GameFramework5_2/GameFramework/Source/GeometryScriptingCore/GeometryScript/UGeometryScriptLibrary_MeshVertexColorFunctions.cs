#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshVertexColorFunctions.h")]
public partial class UGeometryScriptLibrary_MeshVertexColorFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshVertexColorFunctions
	public static UDynamicMesh SetMeshConstantVertexColor(UDynamicMesh TargetMesh,FLinearColor Color,FGeometryScriptColorFlags Flags,bool bClearExisting/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetMeshSelectionVertexColor(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FLinearColor Color,FGeometryScriptColorFlags Flags,bool bCreateColorSeam/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetMeshPerVertexColors(UDynamicMesh TargetMesh,FGeometryScriptColorList VertexColorList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh GetMeshPerVertexColors(UDynamicMesh TargetMesh,FGeometryScriptColorList ColorList,bool bIsValidColorSet,bool bHasVertexIDGaps,bool bBlendSplitVertexValues/*=true*/) { return default; }
	public static UDynamicMesh ConvertMeshVertexColorsSRGBToLinear(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ConvertMeshVertexColorsLinearToSRGB(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
