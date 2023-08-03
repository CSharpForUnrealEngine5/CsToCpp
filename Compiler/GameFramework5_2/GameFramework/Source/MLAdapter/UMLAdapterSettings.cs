#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the MLAdapter plugin.</summary>
[CppInclude("MLAdapterSettings.h")]
public partial class UMLAdapterSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>ManagerClass</summary>
	public FSoftClassPath ManagerClass;
	///<summary>SessionClass</summary>
	public FSoftClassPath SessionClass;
	///<summary>DefaultAgentClass</summary>
	public FSoftClassPath DefaultAgentClass;
	///<summary>DefaultRPCServerPort</summary>
	public ushort DefaultRPCServerPort;
}
