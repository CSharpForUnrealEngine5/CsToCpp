namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionPinBase.h")]
public partial class UMaterialExpressionPinBase : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Underlying reroute pins used to compile material. Must call Modify after editing to update output expressions.</summary>
	public TArray<FCompositeReroute> ReroutePins;
	///<summary>Direction of the pins for this base.</summary>
	public EEdGraphPinDirection PinDirection;
}
