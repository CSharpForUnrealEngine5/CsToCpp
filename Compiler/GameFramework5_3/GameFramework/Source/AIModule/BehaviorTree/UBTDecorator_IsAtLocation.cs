namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Is At Location decorator node.</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_IsAtLocation.h")]
public partial class UBTDecorator_IsAtLocation : UBTDecorator_BlackboardBase {
	public static UClass StaticClass() {return default;}
	///<summary>distance threshold to accept as being at location</summary>
	public float AcceptableRadius;
	///<summary>ParametrizedAcceptableRadius</summary>
	public FAIDataProviderFloatValue ParametrizedAcceptableRadius;
	///<summary>GeometricDistanceType</summary>
	public FAIDistanceType GeometricDistanceType;
	///<summary>bUseParametrizedRadius</summary>
	public bool bUseParametrizedRadius;
	///<summary>if moving to an actor and this actor is a nav agent, then we will move to their nav agent location</summary>
	public bool bUseNavAgentGoalLocation;
	///<summary>If true the result will be consistent with tests done while following paths.</summary>
	public bool bPathFindingBasedTest;
}
