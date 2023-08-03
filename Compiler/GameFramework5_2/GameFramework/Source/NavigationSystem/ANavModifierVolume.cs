#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows applying selected AreaClass to navmesh, using Volume&#39;s shape</summary>
[CppInclude("NavModifierVolume.h")]
public partial class ANavModifierVolume : AVolume {
	public static UClass StaticClass() {return default;}
	///<summary>AreaClass</summary>
	public UClass AreaClass;
	///<summary>Experimental: if set, the 2D space occupied by the volume box will ignore FillCollisionUnderneathForNavmesh</summary>
	public bool bMaskFillCollisionUnderneathForNavmesh;
	///<summary>Experimental: When not set to None, the navmesh tiles touched by the navigation modifier volume will be built</summary>
	public ENavigationDataResolution NavMeshResolution;
	///<summary>SetAreaClass</summary>
	public  void SetAreaClass(UClass NewAreaClass/*=nullptr*/) {}
}
