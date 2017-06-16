.paket/paket.bootstrapper.exe
.paket/paket.exe restore
dotnet restore ./tests/canopytests/
dotnet run ./tests/canopytests/canopytests.fsproj

