#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Project Settings for Plastic SCM Source Control. Saved in Config/DefaultEditor.ini</summary>
[CppInclude("PlasticSourceControlProjectSettings.h")]
public partial class UPlasticSourceControlProjectSettings : UDeveloperSettings {
	///<summary>Map Plastic SCM user names (typically e-mail addresses or company domain names) to display names for brevity.</summary>
	public TMap<string,string> UserNameToDisplayName;
	///<summary>Hide the domain part of an username e-mail address (eg @gmail.com) if the UserNameToDisplayName map didn&#39;t match (enabled by default).</summary>
	public bool bHideEmailDomainInUsername;
	///<summary>If enabled, you&#39;ll be prompted to check out changed files (enabled by default). Checkout is needed to work with Changelists.</summary>
	public bool bPromptForCheckoutOnChange;
	///<summary>If a non-null value is set, limit the maximum number of revisions requested to Plastic SCM to display in the &quot;History&quot; window.</summary>
	public int LimitNumberOfRevisionsInHistory;
}
