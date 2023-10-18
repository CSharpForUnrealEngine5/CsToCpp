namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolContextInterfaces.h")]
///<summary>Level of severity of messages emitted by Tool framework</summary>
public enum EToolMessageLevel {
	Internal=0,
	UserMessage=1,
	UserNotification=2,
	UserWarning=3,
	UserError=4,
}
