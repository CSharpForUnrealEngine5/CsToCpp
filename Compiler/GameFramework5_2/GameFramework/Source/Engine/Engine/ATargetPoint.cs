namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TargetPoint.h")]
public partial class ATargetPoint : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>ArrowComponent</summary>
	public UArrowComponent ArrowComponent;
}
