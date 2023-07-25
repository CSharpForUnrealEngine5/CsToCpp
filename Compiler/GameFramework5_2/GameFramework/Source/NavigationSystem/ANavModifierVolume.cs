#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavModifierVolume.h")]
///<summary>Allows applying selected AreaClass to navmesh, using Volume's shape</summary>
public partial class ANavModifierVolume : AVolume {
// NavModifierVolume
	public UClass AreaClass;
	public bool bMaskFillCollisionUnderneathForNavmesh;
	public ENavigationDataResolution NavMeshResolution;
	public void SetAreaClass(UClass NewAreaClass/*=nullptr*/) {}
}
