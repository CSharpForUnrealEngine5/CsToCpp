#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A serializable config for an agent. Used in the external API to define agents.</summary>
[CppInclude("Agents/MLAdapterAgent.h")]
public partial struct FMLAdapterAgentConfig {
	public TMap<string,FMLAdapterParameterMap> Sensors;
	public TMap<string,FMLAdapterParameterMap> Actuators;
	public string AvatarClassName;
	public string AgentClassName;
	public bool bAvatarClassExact;
	public bool bAutoRequestNewAvatarUponClearingPrev;
}
