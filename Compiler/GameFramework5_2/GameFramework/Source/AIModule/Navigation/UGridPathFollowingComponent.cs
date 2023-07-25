#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/GridPathFollowingComponent.h")]
///<summary>Path following augmented with local navigation grids</summary>
public partial class UGridPathFollowingComponent : UPathFollowingComponent {
// GridPathFollowingComponent
	public UNavLocalGridManager GridManager;
}
