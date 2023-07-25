#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
///<summary>Describes how the linked lane relates to the lane spatially.</summary>
public enum EZoneLaneLinkType {
	None=0,
	All=-1,
	Outgoing=-1,
	Incoming=-1,
	Adjacent=-1,
}
