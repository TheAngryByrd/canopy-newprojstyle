#!/usr/bin/env bash
export FrameworkPathOverride=$(dirname $(which mono))/../lib/mono/4.5/
mono .paket/paket.bootstrapper.exe
mono .paket/paket.exe restore
pushd ./tests/canopytests/
dotnet restore 
dotnet mono -f net461 --restore
popd
