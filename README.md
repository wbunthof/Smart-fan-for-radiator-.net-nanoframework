# Smart Fan Controller

A .NET nanoFramework starter application for an ESP32-S3-MINI-1-N8-based board.
The project includes the ESP32 hardware library and a minimal application entry
point; it intentionally does not assume GPIO assignments for a particular
carrier board.

## Requirements

- .NET SDK 8.0 or later
- nanoFramework firmware for the ESP32-S3, flashed to the board
- A serial connection to the board for firmware installation

Install the nanoFramework firmware flasher:

```sh
dotnet tool install --global nanoff
```

Put the board in download mode if required by its carrier board, then install
the ESP32-S3 Quad firmware (replace the serial port as appropriate):

```sh
nanoff --target ESP32_S3_QUAD --serialport COM3 --update
```

On Linux, the port is typically something like `/dev/ttyUSB0` or
`/dev/ttyACM0`. Check the nanoFramework ESP32-S3 target documentation and the
carrier board's instructions if a different firmware variant or boot procedure
is required.

## Build and deploy

Build the project from the repository root:

```sh
dotnet build
```

Open `SmartFanController.csproj` in Visual Studio with the nanoFramework
extension installed to deploy and debug the application over the device's
serial connection. The starter application writes a startup message to the
nanoFramework debug output and then remains running.
