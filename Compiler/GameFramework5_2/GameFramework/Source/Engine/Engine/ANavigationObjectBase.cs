#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/NavigationObjectBase.h")]
public partial class ANavigationObjectBase : AActor {
// NavigationObjectBase
	public UCapsuleComponent CapsuleComponent;
	public UBillboardComponent GoodSprite;
	public UBillboardComponent BadSprite;
	public bool bIsPIEPlayerStart;
}
