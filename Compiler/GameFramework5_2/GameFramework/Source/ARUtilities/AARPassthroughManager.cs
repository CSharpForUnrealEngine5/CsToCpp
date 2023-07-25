#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARPassthroughManager.h")]
///<summary>A helper actor that collects the ARComponent in the scene and apply the passthrough material to them.</summary>
public partial class AARPassthroughManager : AActor {
// ARPassthroughManager
	public UObject GetPassthroughMaterialUpdateComponent() { return default; }
	public TArray<UClass> ARComponentClasses;
	public UPassthroughMaterialUpdateComponent PassthroughUpdateComponent;
}
