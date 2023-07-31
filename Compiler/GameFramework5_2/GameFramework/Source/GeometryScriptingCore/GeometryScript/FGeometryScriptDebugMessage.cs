#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/GeometryScriptTypes.h")]
public partial struct FGeometryScriptDebugMessage {
	public EGeometryScriptDebugMessageType MessageType;
	public EGeometryScriptErrorType ErrorType;
	public string Message;
}
