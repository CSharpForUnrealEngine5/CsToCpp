namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An object used internally by the New Plugin Wizard to set user-defined plugin descriptor information.</summary>
[CppInclude("NewPluginDescriptorData.h")]
public partial class UNewPluginDescriptorData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The author of this content</summary>
	public string CreatedBy;
	///<summary>Optional hyperlink for the author&#39;s website</summary>
	public string CreatedByURL;
	///<summary>A description for this content</summary>
	public string Description;
	///<summary>Marks this content as being in beta</summary>
	public bool bIsBetaVersion;
}
