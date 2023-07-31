#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTCompositeNode.h")]
///<summary>keep in sync with DescribeLogicOp() in BTCompositeNode.cpp</summary>
[CppEnumInNamespace]
public enum EBTDecoratorLogic {
	Invalid=0,
	Test=1,
	And=2,
	Or=3,
	Not=4,
}
