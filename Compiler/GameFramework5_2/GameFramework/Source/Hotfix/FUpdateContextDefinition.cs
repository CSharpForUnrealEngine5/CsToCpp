#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Update context definition loaded from config.</summary>
[CppInclude("UpdateManager.h")]
public partial struct FUpdateContextDefinition {
	public string Name;
	public bool bEnabled;
	public bool bCheckAvailabilityOnly;
	public bool bPatchCheckEnabled;
	public bool bPlatformEnvironmentDetectionEnabled;
	public TSet<string> AdditionalTags;
}
