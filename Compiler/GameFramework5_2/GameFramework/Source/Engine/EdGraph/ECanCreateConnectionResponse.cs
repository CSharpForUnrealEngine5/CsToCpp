#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraphSchema.h")]
///<summary>This is the type of response the graph editor should take when making a connection</summary>
public enum ECanCreateConnectionResponse {
	CONNECT_RESPONSE_MAKE=0,
	CONNECT_RESPONSE_DISALLOW=1,
	CONNECT_RESPONSE_BREAK_OTHERS_A=2,
	CONNECT_RESPONSE_BREAK_OTHERS_B=3,
	CONNECT_RESPONSE_BREAK_OTHERS_AB=4,
	CONNECT_RESPONSE_MAKE_WITH_CONVERSION_NODE=5,
	CONNECT_RESPONSE_MAKE_WITH_PROMOTION=6,
	CONNECT_RESPONSE_MAX=7,
}
