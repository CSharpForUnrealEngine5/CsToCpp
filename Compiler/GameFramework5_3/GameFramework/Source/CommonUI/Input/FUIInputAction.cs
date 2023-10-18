namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Input/CommonUIInputSettings.h")]
public partial struct FUIInputAction {
	public FUIActionTag ActionTag;
	public FText DefaultDisplayName;
	public TArray<FUIActionKeyMapping> KeyMappings;
}
