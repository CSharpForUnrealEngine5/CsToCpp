#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A CloudARPin will be created when you host an existing ARPin, or resolved a</summary>
[CppInclude("GoogleARCoreServicesTypes.h")]
public partial class UCloudARPin : UARPin {
	///<summary>Gets the CloudID of this CloudARPin.</summary>
	public  string GetCloudID() { return default; }
	///<summary>Gets the current cloud state of this CloudARPin.</summary>
	public  ECloudARPinCloudState GetARPinCloudState() { return default; }
}
