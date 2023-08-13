namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds info on an instance communicating through concert</summary>
[CppInclude("ConcertMessageData.h")]
public partial struct FConcertInstanceInfo {
	public FGuid InstanceId;
	public string InstanceName;
	public string InstanceType;
}
