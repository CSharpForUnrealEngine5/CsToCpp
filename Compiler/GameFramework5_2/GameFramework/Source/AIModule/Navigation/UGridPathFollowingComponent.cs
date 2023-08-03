#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Path following augmented with local navigation grids</summary>
[CppInclude("Navigation/GridPathFollowingComponent.h")]
public partial class UGridPathFollowingComponent : UPathFollowingComponent {
	public static UClass StaticClass() {return default;}
	///<summary>GridManager</summary>
	public UNavLocalGridManager GridManager;
}
