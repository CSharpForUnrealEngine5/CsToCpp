#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MirrorTool.h")]
public partial class UMirrorToolActionPropertySet : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Move the mirror plane to center of bounding box without changing its normal.</summary>
	public  void ShiftToCenter() {}
	///<summary>Move the mirror plane and adjust its normal to mirror entire selection leftward.</summary>
	public  void Left() {}
	///<summary>Move the mirror plane and adjust its normal to mirror entire selection rightward.</summary>
	public  void Right() {}
	///<summary>Move the mirror plane and adjust its normal to mirror entire selection upward.</summary>
	public  void Up() {}
	///<summary>Move the mirror plane and adjust its normal to mirror entire selection downward.</summary>
	public  void Down() {}
	///<summary>Move the mirror plane and adjust its normal to mirror entire selection forward.</summary>
	public  void Forward() {}
	///<summary>Move the mirror plane and adjust its normal to mirror entire selection backward.</summary>
	public  void Backward() {}
}
