namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base for fast array items. For replication of new entity types this type should be inherited from. FReplicatedAgentBase should also be inherited from</summary>
[CppInclude("MassClientBubbleHandler.h")]
public partial struct FMassFastArrayItemBase {
	public FMassReplicatedAgentHandle Handle;
}
