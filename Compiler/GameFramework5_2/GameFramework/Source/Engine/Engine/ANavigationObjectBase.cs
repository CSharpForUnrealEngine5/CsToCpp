#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/NavigationObjectBase.h")]
public partial class ANavigationObjectBase : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>CapsuleComponent</summary>
	public UCapsuleComponent CapsuleComponent;
	///<summary>Normal editor sprite.</summary>
	public UBillboardComponent GoodSprite;
	///<summary>Used to draw bad collision intersection in editor.</summary>
	public UBillboardComponent BadSprite;
	///<summary>True if this nav point was spawned to be a PIE player start.</summary>
	public bool bIsPIEPlayerStart;
}
