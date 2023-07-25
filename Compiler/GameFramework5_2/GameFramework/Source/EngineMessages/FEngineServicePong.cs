#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EngineServiceMessages.h")]
///<summary>Implements a message for responding to a request to discover engine instances on the network.</summary>
public partial struct FEngineServicePong {
// EngineServicePong
	public string CurrentLevel;
	public int EngineVersion;
	public bool HasBegunPlay;
	public FGuid InstanceId;
	public string InstanceType;
	public FGuid SessionId;
	public float WorldTimeSeconds;
}
