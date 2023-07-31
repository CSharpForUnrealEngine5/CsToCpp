#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for responding to a request to discover engine instances on the network.</summary>
[CppInclude("EngineServiceMessages.h")]
public partial struct FEngineServicePong {
	public string CurrentLevel;
	public int EngineVersion;
	public bool HasBegunPlay;
	public FGuid InstanceId;
	public string InstanceType;
	public FGuid SessionId;
	public float WorldTimeSeconds;
}
