#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An object used internally by the New Plugin Wizard to set user-defined plugin descriptor information.</summary>
[CppInclude("NewPluginDescriptorData.h")]
public partial class UNewPluginDescriptorData : UObject {
	///<summary>The author of this content</summary>
	public string CreatedBy;
	///<summary>Optional hyperlink for the author&#39;s website</summary>
	public string CreatedByURL;
	///<summary>A description for this content</summary>
	public string Description;
	///<summary>Marks this content as being in beta</summary>
	public bool bIsBetaVersion;
}
