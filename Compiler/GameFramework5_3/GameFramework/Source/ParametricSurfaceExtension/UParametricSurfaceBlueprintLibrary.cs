namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ParametricSurfaceBlueprintLibrary.h")]
public partial class UParametricSurfaceBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Re-tessellate LOD 0 of a static mesh if it contains parametric surface data.</summary>
	public static bool RetessellateStaticMesh(UStaticMesh StaticMesh,FDatasmithRetessellationOptions TessellationSettings,FText FailureReason) { return default; }
	///<summary>Re-tessellate LOD 0 of a static mesh if it contains parametric surface data.</summary>
	public static bool RetessellateStaticMeshWithNotification(UStaticMesh StaticMesh,FDatasmithRetessellationOptions TessellationSettings,bool bApplyChanges,FText FailureReason) { return default; }
}
