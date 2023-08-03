#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/Navigation/NavCollisionBase.h")]
public partial class UNavCollisionBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If set, mesh will be used as dynamic obstacle (don&#39;t create navmesh on top, much faster adding/removing)</summary>
	public bool bIsDynamicObstacle;
}
