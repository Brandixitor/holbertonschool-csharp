#!/usr/bin/env bash
dotnet new console -o 0-new_project && cd 1-new_project && dotnet build && dotnet run --project 2-new_project/2-new_project.csproj
