#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Decorators/BTDecorator_IsAtLocation.h")]
///<summary>Is At Location decorator node.</summary>
public partial class UBTDecorator_IsAtLocation : UBTDecorator_BlackboardBase {
// BTDecorator_IsAtLocation
	public float AcceptableRadius;
	public FAIDataProviderFloatValue ParametrizedAcceptableRadius;
	public FAIDistanceType GeometricDistanceType;
	public bool bUseParametrizedRadius;
	public bool bUseNavAgentGoalLocation;
	public bool bPathFindingBasedTest;
}
