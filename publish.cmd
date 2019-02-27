@echo off
@msbuild build.msbuild /t:PublishRelease /p:NugetSecret=<insert secret here>