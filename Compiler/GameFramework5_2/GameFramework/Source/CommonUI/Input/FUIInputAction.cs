#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Input/CommonUIInputSettings.h")]
public partial struct FUIInputAction {
// UIInputAction
	public FUIActionTag ActionTag;
	public string DefaultDisplayName;
	public TArray<FUIActionKeyMapping> KeyMappings;
}
