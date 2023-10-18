namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores all mappings bound to a single mapping name.</summary>
[CppInclude("UserSettings/EnhancedInputUserSettings.h")]
public partial struct FKeyMappingRow {
	public TSet<FPlayerKeyMapping> Mappings;
}
