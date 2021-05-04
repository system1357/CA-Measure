# CA-Measure
CA-Measure is a Konica Minolta CA-100Plus/CA-210/CA-310 color analyzer remote measuring program for batch display brightness measurement.

### Usage Notes

1. Install x64 version of CA-SDK from Konica Minolta first, you can get it [here](https://www.konicaminolta.com/instruments/download/software/display/ca-sdk/index.html)
2. Install Access Database Engine Redist [here](https://www.microsoft.com/en-us/download/details.aspx?id=54920)
3. Load command list before batch measuring, you can save a template list by pressing "Save Data" first and add commands to the cmd column

### Known Issues
1. "No." column won't auto refresh when measurement data is deleted 
2. Serial communication test fails on non-Linux serial targets 
3. Driver & SDK installation detection not implemented

### Build Status
[![CI](https://github.com/system1357/CA-Measure/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/system1357/CA-Measure/actions/workflows/build.yml)
