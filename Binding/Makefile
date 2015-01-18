MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild

all: Makefile ApiDefinition.cs StructsAndEnums.cs libGPUImage.a
	$(MONOXBUILD) /p:Configuration=Release MonoTouch.GPUImage.csproj
	cp bin/Release/MonoTouch.GPUImage.dll MonoTouch.GPUImage.dll

clean:
	-rm -rf list ios *.dll *.zip *.mdb bin/ obj/