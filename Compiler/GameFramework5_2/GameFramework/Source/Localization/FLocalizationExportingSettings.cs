#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocalizationTargetTypes.h")]
public partial struct FLocalizationExportingSettings {
	public ELocalizedTextCollapseMode CollapseMode;
	public EPortableObjectFormat POFormat;
	public bool ShouldPersistCommentsOnExport;
	public bool ShouldAddSourceLocationsAsComments;
}
