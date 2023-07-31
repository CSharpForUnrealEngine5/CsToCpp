#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Input/CommonUIInputSettings.h")]
public partial struct FUIInputAction {
	public FUIActionTag ActionTag;
	public string DefaultDisplayName;
	public TArray<FUIActionKeyMapping> KeyMappings;
}
