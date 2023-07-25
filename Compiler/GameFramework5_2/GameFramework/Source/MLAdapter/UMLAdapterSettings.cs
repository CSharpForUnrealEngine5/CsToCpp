#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MLAdapterSettings.h")]
///<summary>Implements the settings for the MLAdapter plugin.</summary>
public partial class UMLAdapterSettings : UDeveloperSettings {
// MLAdapterSettings
	public FSoftClassPath ManagerClass;
	public FSoftClassPath SessionClass;
	public FSoftClassPath DefaultAgentClass;
	public ushort DefaultRPCServerPort;
}
