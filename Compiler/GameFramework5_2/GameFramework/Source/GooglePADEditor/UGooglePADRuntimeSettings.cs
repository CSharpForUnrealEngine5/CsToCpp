#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the GooglePAD plugin.</summary>
[CppInclude("GooglePADRuntimeSettings.h")]
public partial class UGooglePADRuntimeSettings : UObject {
	///<summary>Enable GooglePAD plugin</summary>
	public bool bEnablePlugin;
	///<summary>Only for distribution builds</summary>
	public bool bOnlyDistribution;
	///<summary>Only for shipping builds</summary>
	public bool bOnlyShipping;
}
