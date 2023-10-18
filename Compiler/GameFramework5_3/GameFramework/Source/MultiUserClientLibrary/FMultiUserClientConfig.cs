namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MultiUserClientStatics.h")]
public partial struct FMultiUserClientConfig {
	public string DefaultServerURL;
	public string DefaultSessionName;
	public string DefaultSessionToRestore;
	public EMultiUserSourceValidationMode ValidationMode;
}
