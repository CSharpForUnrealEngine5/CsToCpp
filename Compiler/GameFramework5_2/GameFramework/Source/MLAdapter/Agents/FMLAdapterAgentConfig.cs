namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A serializable config for an agent. Used in the external API to define agents.</summary>
[CppInclude("Agents/MLAdapterAgent.h")]
public partial struct FMLAdapterAgentConfig {
	public TMap<FName,FMLAdapterParameterMap> Sensors;
	public TMap<FName,FMLAdapterParameterMap> Actuators;
	public FName AvatarClassName;
	public FName AgentClassName;
	public bool bAvatarClassExact;
	public bool bAutoRequestNewAvatarUponClearingPrev;
}
