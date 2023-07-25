#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request to create an event hook.</summary>
public partial struct FRemoteControlObjectEventHookRequest {
// RemoteControlObjectEventHookRequest
	public ERemoteControlEvent EventType;
	public string ObjectPath;
	public string PropertyName;
}
