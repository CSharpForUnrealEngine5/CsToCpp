#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IVirtualCameraOptions.h")]
public partial class UVirtualCameraOptions : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Sets unit of distance.</summary>
	public  void SetDesiredDistanceUnits(EUnit DesiredUnits) {}
	///<summary>Returns previously set unit of distance.</summary>
	public  EUnit GetDesiredDistanceUnits() { return default; }
	///<summary>Checks whether or not focus visualization can activate</summary>
	public  bool IsFocusVisualizationAllowed() { return default; }
}
