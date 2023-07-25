#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputRouter.h")]
///<summary>UInputRouter mediates between a higher-level input event source (eg like an FEdMode)</summary>
public partial class UInputRouter : UObject {
// InputRouter
	public bool bAutoInvalidateOnHover;
	public bool bAutoInvalidateOnCapture;
	public UInputBehaviorSet ActiveInputBehaviors;
}
