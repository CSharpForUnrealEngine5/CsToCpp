#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshDeformFunctions.h")]
public partial class UGeometryScriptLibrary_MeshDeformFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>ApplyBendWarpToMesh</summary>
	public static UDynamicMesh ApplyBendWarpToMesh(UDynamicMesh TargetMesh,FGeometryScriptBendWarpOptions Options,FTransform BendOrientation,float BendAngle/*=45f*/,float BendExtent/*=50f*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplyTwistWarpToMesh</summary>
	public static UDynamicMesh ApplyTwistWarpToMesh(UDynamicMesh TargetMesh,FGeometryScriptTwistWarpOptions Options,FTransform TwistOrientation,float TwistAngle/*=45f*/,float TwistExtent/*=50f*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplyFlareWarpToMesh</summary>
	public static UDynamicMesh ApplyFlareWarpToMesh(UDynamicMesh TargetMesh,FGeometryScriptFlareWarpOptions Options,FTransform FlareOrientation,float FlarePercentX/*=0f*/,float FlarePercentY/*=0f*/,float FlareExtent/*=50f*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplyMathWarpToMesh</summary>
	public static UDynamicMesh ApplyMathWarpToMesh(UDynamicMesh TargetMesh,FTransform WarpOrientation,EGeometryScriptMathWarpType WarpType,FGeometryScriptMathWarpOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplyPerlinNoiseToMesh</summary>
	public static UDynamicMesh ApplyPerlinNoiseToMesh(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptPerlinNoiseOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplyIterativeSmoothingToMesh</summary>
	public static UDynamicMesh ApplyIterativeSmoothingToMesh(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptIterativeMeshSmoothingOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplyDisplaceFromTextureMap</summary>
	public static UDynamicMesh ApplyDisplaceFromTextureMap(UDynamicMesh TargetMesh,UTexture2D Texture,FGeometryScriptMeshSelection Selection,FGeometryScriptDisplaceFromTextureOptions Options,int UVLayer/*=0*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Add the vectors in VectorList, scaled by Magnitude, to the vertex positions in TargetMesh.</summary>
	public static UDynamicMesh ApplyDisplaceFromPerVertexVectors(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptVectorList VectorList,float Magnitude/*=5.0f*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
