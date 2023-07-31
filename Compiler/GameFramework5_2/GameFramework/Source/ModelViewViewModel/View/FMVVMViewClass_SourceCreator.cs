#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Shared data to find or create a ViewModel at runtime.</summary>
[CppInclude("View/MVVMViewClass.h")]
public partial struct FMVVMViewClass_SourceCreator {
	public UClass ExpectedSourceType;
	public FMVVMViewModelContext GlobalViewModelInstance;
	public FMVVMVCompiledFieldPath FieldPath;
	public string PropertyName;
	public bool bCreateInstance;
	public bool bOptional;
}
