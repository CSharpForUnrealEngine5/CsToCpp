#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This component may be attached to an actor to allow UI interactions to be</summary>
[CppInclude("PixelStreamingInputComponent.h")]
public partial class UPixelStreamingInput : UActorComponent {
	///<summary>The delegate which will be notified about a UI interaction.</summary>
	public  void FOnInput(string Descriptor) {}
	///<summary>OnInputEvent</summary>
	public FOnInput OnInputEvent;
	///<summary>Send a response back to the source of the UI interactions.</summary>
	public  void SendPixelStreamingResponse(string Descriptor) {}
	///<summary>Helper function to extract a string field from a JSON descriptor of a</summary>
	public  void GetJsonStringValue(string Descriptor,string FieldName,string StringValue,bool Success) {}
	///<summary>Helper function to add a string field to a JSON descriptor. This produces</summary>
	public  void AddJsonStringValue(string Descriptor,string FieldName,string StringValue,string NewDescriptor,bool Success) {}
}
