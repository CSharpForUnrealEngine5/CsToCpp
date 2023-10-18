namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/GeometryScriptTypes.h")]
public partial struct FGeometryScriptDebugMessage {
	public EGeometryScriptDebugMessageType MessageType;
	public EGeometryScriptErrorType ErrorType;
	public FText Message;
}
