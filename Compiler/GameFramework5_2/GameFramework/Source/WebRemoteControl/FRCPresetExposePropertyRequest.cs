#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request to expose a property on a preset</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCPresetExposePropertyRequest {
	public string ObjectPath;
	public string PropertyName;
	public string Label;
	public string GroupName;
	public bool EnableEditCondition;
}
