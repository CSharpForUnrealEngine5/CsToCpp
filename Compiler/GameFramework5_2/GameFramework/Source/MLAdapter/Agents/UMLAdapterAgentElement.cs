#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An agent element is any object that can be attached to an agent. Base class for UMLAdapterSensor and UMLAdapterActuator.</summary>
[CppInclude("Agents/MLAdapterAgentElement.h")]
public partial class UMLAdapterAgentElement : UObject {
	///<summary>@note This is not a common counter, meaning Sensors and Actuators (for example) track the ID separately.</summary>
	public uint ElementID;
	///<summary>User-configured name for this element, mostly for debugging purposes but comes in handy when fetching</summary>
	public string Nickname;
}
