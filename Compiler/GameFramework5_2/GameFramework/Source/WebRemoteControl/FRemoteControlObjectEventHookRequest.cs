namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request to create an event hook.</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRemoteControlObjectEventHookRequest {
	public ERemoteControlEvent EventType;
	public string ObjectPath;
	public string PropertyName;
}
