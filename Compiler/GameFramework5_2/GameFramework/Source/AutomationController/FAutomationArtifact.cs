#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAutomationReport.h")]
public partial struct FAutomationArtifact {
	public FGuid Id;
	public string Name;
	public EAutomationArtifactType Type;
	public TMap<string,string> Files;
}
