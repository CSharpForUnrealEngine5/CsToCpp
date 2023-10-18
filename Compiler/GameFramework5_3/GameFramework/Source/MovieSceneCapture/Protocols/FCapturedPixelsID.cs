namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure used as an identifier for a particular buffer within a capture.</summary>
[CppInclude("Protocols/UserDefinedCaptureProtocol.h")]
public partial struct FCapturedPixelsID {
	public TMap<FName,FName> Identifiers;
}
