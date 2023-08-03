#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ParametricSurfaceBlueprintLibrary.h")]
public partial class UParametricSurfaceBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Re-tessellate LOD 0 of a static mesh if it contains parametric surface data.</summary>
	public static bool RetessellateStaticMesh(UStaticMesh StaticMesh,FDatasmithRetessellationOptions TessellationSettings,string FailureReason) { return default; }
	///<summary>Re-tessellate LOD 0 of a static mesh if it contains parametric surface data.</summary>
	public static bool RetessellateStaticMeshWithNotification(UStaticMesh StaticMesh,FDatasmithRetessellationOptions TessellationSettings,bool bApplyChanges,string FailureReason) { return default; }
}
