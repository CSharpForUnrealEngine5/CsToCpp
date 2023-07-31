#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionPinBase.h")]
public partial class UMaterialExpressionPinBase : UMaterialExpression {
	///<summary>Underlying reroute pins used to compile material. Must call Modify after editing to update output expressions.</summary>
	public TArray<FCompositeReroute> ReroutePins;
	///<summary>Direction of the pins for this base.</summary>
	public EEdGraphPinDirection PinDirection;
}
