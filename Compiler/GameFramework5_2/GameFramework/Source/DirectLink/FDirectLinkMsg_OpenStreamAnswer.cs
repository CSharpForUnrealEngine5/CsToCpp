#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectLinkMessages.h")]
public partial struct FDirectLinkMsg_OpenStreamAnswer {
// DirectLinkMsg_OpenStreamAnswer
	public int RecipientStreamPort;
	public bool bAccepted;
	public string Error;
	public int OpenedStreamPort;
}
