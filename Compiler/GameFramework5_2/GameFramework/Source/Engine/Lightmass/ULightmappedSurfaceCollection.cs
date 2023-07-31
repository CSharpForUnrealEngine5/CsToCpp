#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Lightmass/LightmappedSurfaceCollection.h")]
public partial class ULightmappedSurfaceCollection : UObject {
	///<summary>The UModel these surfaces come from.</summary>
	public UModel SourceModel;
	///<summary>An array of the surface indices grouped into a single static lighting mapping.</summary>
	public TArray<int> Surfaces;
}
