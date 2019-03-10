SET PAKET_TOOL_PATH=.paket

IF NOT EXIST "%PAKET_TOOL_PATH%\paket.exe" (
  echo "Paket not found. Installing."
  dotnet tool install paket --tool-path ./%PAKET_TOOL_PATH%
)

"%PAKET_TOOL_PATH%/paket.exe" %*