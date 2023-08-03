#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MIDIDeviceManager.h")]
public partial class UMIDIDeviceManager : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Enumerates all of the connected MIDI devices and reports back with the IDs and names of those devices.  This operation is a little expensive</summary>
	public static void FindMIDIDevices(TArray<FFoundMIDIDevice> OutMIDIDevices) {}
	///<summary>Enumerates all of the MIDI input and output devices and reports back useful infos such as IDs and names of those devices. This operation is a little expensive</summary>
	public static void FindAllMIDIDeviceInfo(TArray<FMIDIDeviceInfo> OutMIDIInputDevices,TArray<FMIDIDeviceInfo> OutMIDIOutputDevices) {}
	///<summary>Retrieves the MIDI input device ID by name. Call &quot;Find All MIDI Device Info&quot; beforehand to enumerate the available input devices.</summary>
	public static void GetMIDIInputDeviceIDByName(string DeviceName,int DeviceID) {}
	///<summary>Retrieves the default MIDI input device ID. Call &quot;Find All MIDI Device Info&quot; beforehand to enumerate the available input devices.</summary>
	public static void GetDefaultMIDIInputDeviceID(int DeviceID) {}
	///<summary>Retrieves the MIDI output device ID by name. Call &quot;Find All MIDI Device Info&quot; beforehand to enumerate the available output devices.</summary>
	public static void GetMIDIOutputDeviceIDByName(string DeviceName,int DeviceID) {}
	///<summary>Retrieves the default MIDI output device ID. Call &quot;Find All MIDI Device Info&quot; beforehand to enumerate the available input devices.</summary>
	public static void GetDefaultMIDIOutputDeviceID(int DeviceID) {}
	///<summary>Creates an instance of a MIDI device controller that can be used to interact with a connected MIDI device</summary>
	public static UMIDIDeviceController CreateMIDIDeviceController(int DeviceID,int MIDIBufferSize/*=1024*/) { return default; }
	///<summary>Creates an instance of a MIDI device controller that can be used to interact with a connected MIDI device</summary>
	public static UMIDIDeviceInputController CreateMIDIDeviceInputController(int DeviceID,int MIDIBufferSize/*=1024*/) { return default; }
	///<summary>Creates an instance of a MIDI output device controller that can be used to interact with a connected MIDI device</summary>
	public static UMIDIDeviceOutputController CreateMIDIDeviceOutputController(int DeviceID) { return default; }
}
